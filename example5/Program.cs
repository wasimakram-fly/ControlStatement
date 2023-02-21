using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter a value: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("Enter b value: ");
            b=int.Parse(Console.ReadLine());
            if (a < b)
            {
                c = a + b;
                Console.WriteLine("Addition: " + c);
            }
            if (a > b)
            {
                c = a - b;
                Console.WriteLine("Substraction: " + c);
            }
            if (a == b)
            {
                c = a * b;
                Console.WriteLine("Multiplication: " + c);
            }

            Console.ReadLine();
        }
    }
}
