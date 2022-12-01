using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class A
{

}
namespace ConsoleApp17_methodoverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c,x;
            a = 12.3f;
            b = 1.1f;
            
            add(2, 3);
            add(2.3f, 3);
            add(2, 3.2f);
            add(3.2f, 5.6f, 5.6f);
            add(3.2f, 5.6f,7.8f,8.9f,1.1f );
            add(ref a, ref b,out c);
            Console.WriteLine("reference c{0} ", c);
            Console.ReadKey();
        }


        //overloading with type of method parameters
        public static void add(int a, int b)
        {
            Console.WriteLine("sum of int int: {0}", a + b);
        }
        public static void add(float a, float b)
        {
            Console.WriteLine("sum of float float: {0}", a + b);
        }


        public static void add(float a, int b)
        {
            Console.WriteLine("sum of float int: {0}", a + b);
        }
        //overloading with order of parameter
        public static void add(float a, float b, float c)
        {
            Console.WriteLine("sum of float float float: {0}", a + b + c);
        }


        //method overloading by different kinds of parameter
        public static void add(ref float a, ref float b, out float c)
        {
            c = a + b * 2;
            Console.WriteLine("one parameter is out sum: {0}", c);
        }

        public static void add(float a, float b, params float[] c)
        {
            Console.WriteLine("sum: {0}", 55);
        }

        //conflict with using params and array of params type

        //public static void add(float a, float b, float[] c)
        //{
        //    Console.WriteLine("sum: {0}", 55);
        //}
    }
}
