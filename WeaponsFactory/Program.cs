using System;
using System.Collections.Generic;
using System.Linq;
namespace WeaponsFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //[weapon name][damage]
            string input = null;
            List<Weapon> ctx = new List<Weapon>();

            while ((input = Console.ReadLine()) != "end")
            {
                var data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                bool result = Enum.GetNames(typeof(WeaponType)).Contains(data[0].ToLower());
                if (!result)
                {
                    Console.WriteLine("You can create only three types of weapons - gun, knife or bow!");
                }
                else
                {
                    Weapon weapon = new Weapon(data[0], int.Parse(data[1]));
                    var temp = ctx.FirstOrDefault(x => x.Name == weapon.Name);
                    if (temp != null)
                    {
                        temp.Damage += weapon.Damage;
                        weapon.InflictDamage(temp.Name, temp.Damage);
                    }
                    else
                    {
                        ctx.Add(new Weapon(data[0], int.Parse(data[1])));
                        weapon.InflictDamage(weapon.Name, weapon.Damage);
                    }
                }
            }
        }
    }
}
