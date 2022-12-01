using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14_abstract
{
    /*
     *abstraction
     *definition-hiding implementation details from user
     *0% abstraction concrete class
     *1-99% abstraction-abstract class
     *100% abstraction - interfaces
     */


    /*
     Abstract class
    1. use abstract keyworkd to declare/define abstract class or methods
    2.abstract class may or may not have abstract methods in c#
    3.can have concrete methods
    4.can have constants
    5.can have constructors and destructors
    6.normally used for creating base classes
    7.we can create reference var of abstract class
    8.we can't instantiate(can't create object) of abstract calss
    9.abstract classess or method cannot be sealed
    10.abstract class cant be static
    11.abstract methods of abstract class are virtual by defult
    12.in order to inherit from abstract class derived class has to
    implement abstract method or declare ritself as abstract 
    13.destructor cannot have public or private modifier explicitly
    14.abstract class can have abstract property 
    15.if only get accessor is declared in abstract property 
       its readonly field
    set cannot be inherited since not declared


     */


   abstract class abs

    {
        
        public abstract string Name { get;/* set;*/ }
        //public abs()
        //{
        //    Console.WriteLine("Abstract() - constructor called");
        //}

        //~abs()
        //{
        //    Console.WriteLine("abs()- destructor callled");
        //}

        //public const string dept = "dept of data science and technology";

        //public void show()
        //{
        //    Console.WriteLine("abs-show() method called\n" +
        //        "concrete method");
        //}

        public abstract void run();
    }



    class derived : abs
    {
        public string name;
        public override string Name { get { return "Saumik Dutta"; } 
            /*set { name= value; }*/ }   

        public override void run()
        {
            Console.WriteLine("derived-run() called");
            Console.WriteLine("Name:{0}", this.Name);

        }
    }

    //class derived1:abs
    //{

    //}
    internal class Program
    {
        static void Main(string[] args)
        {

           // abs a=new abs();
            abs a=new derived();//cre3ating reference type of abstract class
            //
           // a.Name = "saumik";
            a.run();

            Console.ReadKey();
        }
    }
}
