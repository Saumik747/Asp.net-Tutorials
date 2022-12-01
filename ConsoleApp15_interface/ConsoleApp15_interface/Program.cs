using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 interface 
0 supports multiple inheritance
1.100% abstraction
2.cant have method definition
3.by default methods inside interface are abstract in nature
4.explicit use of abstract modifier is not allowed
5.instance data member are not allowed
 6.interface can inherit from another interface without defining member function
7.cannot instantiate or create object or interface
8.refernece type of interface can be created
9.explicit implementation of interface methods with smae name in case of explicit
10.to call explicitly defined method typecasting is neccessary
11.default explicit implementation is possible for only one interface 
and can be called without typecasting of derved class object
 */
namespace ConsoleApp15_interface
{

    //interface calc
    //{
    //   // public const double pi=3.145;
    //    void add();
    //}

    //interface sci_calc:calc
    //{
    //    void sci_add();
    //}

    //interface vedik_calc:sci_calc
    //{
    //    void vedic_add();
    //}

    //class calcuser: /*vedik_calc*/ calc, sci_calc, vedik_calc
    //{
    //    public void add()
    //    {
    //        Console.WriteLine("Method overriden from calc interface");
    //    }

    //    public void sci_add()
    //    {
    //        Console.WriteLine("Method overriden from sci_calc interface");
    //    }


    //    public void vedic_add()
    //    {
    //        Console.WriteLine("Method overriden from vedic_calc interface");
    //    }
    //}

    interface calc
    {
        // public const double pi=3.145;
        void add();
    }

    interface sci_calc 
    {
        void add();
    }

    interface vedik_calc
    {
        void add();
    }

    class calcuser :  calc, sci_calc, vedik_calc
    {
        //default implementation
        public void add()
        {
            Console.WriteLine("Explicit implementation normal vedik_calc-add() method called");
        }

        void calc.add()
        {
            Console.WriteLine("Explicit implementation calc Add() method called");
        }

        void sci_calc.add()
        {
            Console.WriteLine("Explicit implementation sci_calc Add() method called");
        }

        //void vedik_calc.add()
        //{
        //    Console.WriteLine("Explicit implementation vedik_calc Add() method called");
        //}


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //calcuser cal = new calcuser();
            //cal.add();
            //cal.sci_add();
            //cal.vedic_add();

            ////calc calc = new calc();

            ////can create interface reference type 
            //vedik_calc calc = new calcuser();
            //calc.add();
            //calc.sci_add();
            //calc.vedic_add();

            //using type casting of derived class obejct
            // for calling explicitly defined interface methods
            calcuser cal = new calcuser();
            cal.add();
           ((calc)cal).add();
           ((sci_calc)cal).add();
          // ((vedik_calc)cal).add();//


            Console.ReadKey();
        }
    }
}
