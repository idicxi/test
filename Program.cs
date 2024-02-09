using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            
            int b = Convert.ToInt32(Console.ReadLine());
    
            if (a > b) {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ваше число:");
                Console.ForegroundColor = ConsoleColor.Red;
                
                Console.WriteLine(a);
            }
            if (a < b)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ваше число:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(b);
            }

            Console.ReadKey();
           
        }
    }
}
