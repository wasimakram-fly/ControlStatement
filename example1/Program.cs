using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Value: ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Enter b Value: ");
            int b=int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(" b is big: " + b);
            }
            Console.ReadLine();
        }
    }
}
