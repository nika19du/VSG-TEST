using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LastAndSecondLast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var reversWord = input.Reverse().ToArray();

            var result = new List<char>(2);
            int count = 0;
            for (int i = 0; i < reversWord.Length; i++)
            {
                var word = reversWord[i];
                if (count == 2)
                {
                    break;
                }
                result.Add(reversWord[i]);
                count++;
            }
            Console.WriteLine(result[0] + " " + result[1]);
        }
    }
}
