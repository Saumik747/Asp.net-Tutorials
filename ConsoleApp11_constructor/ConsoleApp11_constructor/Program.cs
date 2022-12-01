using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//constructor
/*
 1.called when object is created
2.having same name as classname
3.does not have return type ie void or int or string

4.comiler bydefault provides definition 
if no user defined constructor available

5.in case of derived class constructor is the 
first line of code is super()

6.constructor chaining is followed while creating 
and deleteing child objects in inheritance

types
1.default(compiler provided)
2.default(user defined)
3.parameterised(user defined)
4.static constructor
5.copy constructor (compiler provided )
6.copy constructor (user defined)
7.private constructor
8.default parameterised/argument constructor
9.
 */


namespace ConsoleApp11_constructor
{
    class A
    {
        //int id;
        //string name;
        //static string batch;
        //static string subject;

        ////user defined default constructor
        ////public A()
        ////{
        ////    Console.WriteLine("A- user defined Default Constructor");
        ////}



        ////static constructor
        ////called before all instance constructors 
        ////called only once
        ////intialized the static DataMisalignedException member
        //static A()
        //{
        //    batch = "MCA2123";
        //    subject = "Web technology-2";

        //    Console.WriteLine("static called");

        //}

        ////there can be only one static constructor in any class
        ////static A()
        ////{

        ////}

        ////default parameterised constructor
        //public A():this(0,"no name provided")
        //{
        //    Console.WriteLine("A- user Default parameterised Constructor");
        //}

        ////parameterised constructor
        //public A(int id,string name)
        //{
        //    this.id = id;
        //    this.name = name;
        //}

        //public A(A b)
        //{
        //    id = b.id;
        //    name = b.name;
        //}

        

        //~A()
        //{
        //    Console.WriteLine("Destructor called");
        //}

        ////variable argiument
        //public A(params int[] p){
        //    foreach (int i in p)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //public void show()
        //{
        //    Console.WriteLine("A-show()");
        //   // Console.WriteLine("id:{0}  name:{1}", id, name);
        //}

        /************************************************/
        static int inst_code;
        static string inst_name;
        private A()
        {
            Console.WriteLine("calling private constructor");
        }
        static A()
        {
            inst_code = 365;
            inst_name = "KJSIM";
        }
        

        public static void show()
        {
            Console.WriteLine("inst_code:{0}  inst_name:{1}", inst_code, inst_name);
        }



    }


    class Base
    {
        protected string name;

        public Base()
        {
            Console.WriteLine("Base() called");
        }
    }

    class Derived:Base
    {
        protected string city;

        public Derived()
        {
            Console.WriteLine("Derived() called");
        }
    }

    class Derivedtocall : Derived
    {
        string state;
        public Derivedtocall(string name,string city,string state)
        {
            this.name = name;
            this.city = city;
                this.state = state;
            Console.WriteLine("Derivedtocall() called");
        }

        public void show()
        {
            Console.WriteLine("name:{0} city:{1} state:{2}", this.name, this.city, this.state);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //A a = new A(); a.show();
            //A a1 = new A(1,"hello"); a1.show();


            //A b=new A();
            //b = a1; //calling default copy constructor
            //b.show();

            //A a2 = new A(2, "def");
            //A a3 = new A(a2); //calling userdefined copy constructor

            //a3.show();

            //A a4 = new A(1,2,3,4,5);

            // A a5 = new A();
            //  A.show();
            // Console.WriteLine("Constructor chaining");
            Console.WriteLine("Inheritance");
            Derivedtocall derived = new Derivedtocall("saumik","vashi","maharashtra");
            derived.show();
            
            Console.ReadKey();
        }
    }
}
