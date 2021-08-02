using System;
using System.Collections.Generic;
using System.Linq;
namespace CountDuplicateElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>();
            List<int> data = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int val = int.Parse(Console.ReadLine());
                if (!data.Contains(val))
                {
                    data.Add(val);
                }
                else nums.Add(val);
            }
            Console.WriteLine(nums.Distinct().Count());
        }
    }
}
