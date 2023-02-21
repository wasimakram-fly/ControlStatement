using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++; // increament. 
            }
            while (i < 11); // 11 < 11 false 
            Console.ReadLine();
        }
    }
}
