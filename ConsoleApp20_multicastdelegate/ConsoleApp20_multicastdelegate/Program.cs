using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Multicast delegate points to more than one methods
 * += operator used to add method
 * -= operator is used to remove method
 * works in FIFO fashion i.e it calls the methods in order they
 * are added or removed
 * if multicast delegate methods return value then it will be 
 * the value returnned by last method in the order
 */
public delegate void MDelegate(out int a);
namespace ConsoleApp20_multicastdelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int retvalue=0;
            Console.WriteLine("using multicast delegate");
            MDelegate mdelegate1 = new MDelegate(method1);
            
            mdelegate1 += method2;//add reference operator ("+=")
            mdelegate1 += method3;
            //mdelegate1 += method4;
            retvalue = mdelegate1();
            Console.WriteLine("Multicast delegate returned {0}",retvalue);

            Console.WriteLine("Update multicast delegate calling ...");
            mdelegate1 -= method1;//remove reference operator("-=")
            mdelegate1 += method2;

            retvalue = mdelegate1();
            Console.WriteLine("Multicast delegate returned {0}", retvalue);
            Console.ReadKey();
        }


        public static void method1(out int a)
        {
            a = 11;
            Console.WriteLine("Method1() called");
            return 11;
        }


        public static void method2(out int b)
        {
            b = 22;
            
            Console.WriteLine("Method2() called");
            //return 22;
        }


        public static void method3()
        {
            Console.WriteLine("Method3() called");
            return 33;
        }


        //public static int method4()
        //{
        //    Console.WriteLine("Method4() called");
        //    return 44;
        //}

    }
}
