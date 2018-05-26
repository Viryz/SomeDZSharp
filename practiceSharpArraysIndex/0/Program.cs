using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number of elements");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Max: {0}", array.Max());
            Console.WriteLine("Min: {0}", array.Min());
            Console.WriteLine("Sum: {0}", array.Sum());
            Console.WriteLine("Avg: {0}", array.Average());

            Console.WriteLine("Numbers (% 2 == 1):");

            IEnumerable<int> newArr = from item in array where item % 2 == 1 select item;
            foreach (int item in newArr)
                Console.Write(item + " ");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
