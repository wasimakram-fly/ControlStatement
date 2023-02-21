using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value: ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Enter b value: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int no = int.Parse(Console.ReadLine());
            switch (no)
            {
                case 1:
                    Console.WriteLine("Addition: " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Substraction: " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Multiplication: " + (a * b));
                    break;
                case 4:
                    Console.WriteLine("Division: " + (a / b));
                    break;
                default:
                    Console.WriteLine("Please enter number between 1-4 only.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
