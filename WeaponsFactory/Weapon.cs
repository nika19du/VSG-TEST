using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponsFactory
{
    public class Weapon
    {
        public Weapon() { }
        public Weapon(string name, int damage)
        {
            this.Name = name;
            this.Damage = damage;
        }
        public string Name { get; set; }

        private int damage;
        public int Damage
        {
            get
            {
                if (damage <= 0)
                {
                    throw new ArgumentException("Damage can not be a negative value!");
                }
                return damage;
            }
            set
            {
                damage = value;
            }
        }

        public void InflictDamage(string name, int damage)
        {
            if (name == "knife")
            {
                Console.WriteLine($"{name} stabs for {damage} damage!");
            }
            else if (name == "gun" || name == "bow")
            {
                Console.WriteLine($"{name} shoots for {damage} damage!");
            }
        }
    }
}
