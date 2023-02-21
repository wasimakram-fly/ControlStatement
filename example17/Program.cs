using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the starting number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending number: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Even numbers in the range {0} to {1}:", start, end);

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
