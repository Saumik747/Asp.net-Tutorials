using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//delegates are typesafe function pointers 
/*
 *
 *
 */

public delegate void fp();

namespace ConsoleApp19_delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fp f1 = new fp(show);
            //fp f2 = new fp(print);
            //f1();
            //f2();

            Console.ReadKey();
        }

        public static void show()
        {
            Console.WriteLine("Show method for a delegate demo ");
        }

        public static void print()
        {
            Console.WriteLine("print method for a delegate demo ");
        }
    }
}
