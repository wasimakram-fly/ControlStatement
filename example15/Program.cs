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
            //  finding odd number

            int j;
            Console.Write("Enter the number till where you want to find odd number: ");
            j = int.Parse(Console.ReadLine());
            for(int i = 1; i < j; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
