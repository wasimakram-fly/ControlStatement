using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value: ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Enter b value: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a is greater");
            }
            else if(a == b)
            {
                Console.WriteLine(" a & b are equal");
            }
            else if(a<b)
            {
                Console.WriteLine(" b is greater");
            }
            else if(a!=b)
            {
                Console.WriteLine(" a & b are not equal");
            }
            else
            {
                Console.WriteLine(" all condition are failed");
            }
            Console.ReadLine();
        }
    }
}
