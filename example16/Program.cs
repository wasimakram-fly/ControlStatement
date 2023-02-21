using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  finding even number

            int j;
            Console.Write("Enter the number till where you want to find even number: ");
            j = int.Parse(Console.ReadLine());
            for (int i = 0; i < j; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
