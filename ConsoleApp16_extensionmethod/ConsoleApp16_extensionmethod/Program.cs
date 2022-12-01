using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MCA
{
    public void method1()
    {
        Console.WriteLine("Method1() call");
         }
    public void method2()
    {
        Console.WriteLine("Method2() call");
         }
    public void method3()
    {
        Console.WriteLine("Method3() call");
         }

    //if same method signature exists in both files(original and created class)
    //then method from original class definition will be called
    //example of run time polymorphism
    public void method5(string subj,string prof)
    {
        Console.WriteLine("method5 in mca called {0} {1}",subj,prof);
    }
}


namespace ConsoleApp16_extensionmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MCA m=new MCA();
            m.method1();
            m.method2();
            m.method3();
            m.method4();
            m.method5("saumik","dept of data science");
            Console.ReadKey();

        }
    }
}
