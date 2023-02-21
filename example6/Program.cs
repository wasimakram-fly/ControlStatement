using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int no=int.Parse(Console.ReadLine());
            switch (no)
            {
                case 1:
                    Console.WriteLine("you entered one");
                    break;
                case 2:
                    Console.WriteLine("you entered two");
                    break;
                case 3:
                    Console.WriteLine("you entered three");
                    break;
                case 4:
                    Console.WriteLine("you entered four");
                    break;
                default:
                    Console.WriteLine("Please enter number between 1-4 only.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
