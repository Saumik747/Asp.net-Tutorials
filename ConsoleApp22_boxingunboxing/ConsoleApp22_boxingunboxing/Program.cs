using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22_boxingunboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 101;
            //Object obj = new Object();

            ////boxing a primitvie value to ibject type 
            //obj = a;
            //Console.WriteLine(obj.ToString());


            ////unboxing object type to primitive type
            //int b = (int)obj;
            //Console.WriteLine(b);


            Stack<int> stack = new Stack<int>();
            stack.Push(11);
            stack.Push(12);
            stack.Push(13);
            stack.Push(14);
            stack.Push(15);


            foreach (var v in stack)
                Console.WriteLine(v);
            Console.WriteLine("Peek position is:{0}", stack.Peek());

            stack.Pop();
            Console.WriteLine("Peek position is:{0}",stack.Peek());
          
            stack.Pop();
            Console.WriteLine("Peek position is:{0}",stack.Peek());

            int[] arr = stack.ToArray();
            foreach(var v in arr)
                Console.WriteLine(v);


            Console.WriteLine("check if item 15 exist:{0}", stack.Contains(15));
            Console.WriteLine("check if item 15 exist:{0}", stack.Contains(1));
            Console.ReadKey();  
        }
    }

}
