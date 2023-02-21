using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value: ");
            int b = int.Parse(Console.ReadLine());
            if(a > b)
            {
                Console.WriteLine(" a is greater.");
            }
            if (a == b)
            {
                Console.WriteLine(" a & b are equal.");
            }
            if (a != b)
            {
                Console.WriteLine(" a & b are not equal.");
            }
            Console.ReadLine();
        }
    }
}
