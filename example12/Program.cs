using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example12
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            int i, sum = 0;
            for (i = 1; i <= 5; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(" sum value of is: " + sum);
            Console.ReadLine();
        }
    }
}
