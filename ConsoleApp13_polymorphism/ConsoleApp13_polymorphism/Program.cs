using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Base
{
    public virtual void show()
    {
        Console.WriteLine("base class -show()");
    }
}

class Derived1 : Base
{
    //public  void show()
    //{
    //    //base.show();
    //    Console.WriteLine("Derived1 -show()");
    //}
    public override void show()
    {
        //base.show();
        Console.WriteLine("derived1 -show()");
    }

}

class Derived2 : Base
{
    //public void show()
    //{
    //    base.show();
    //    Console.WriteLine("Derived2 -show()");
    //}

    public override void show()
    {
        //base.show();
        Console.WriteLine("derived2 -show()");
    }
}

class Derived3 : Base
{
    //public  void show()
    //{
    //    //base.show();
    //    Console.WriteLine("Derived3 -show()");
    //}

    public override void show()
    {
        //base.show();
        Console.WriteLine("Derived3 -show()");
    }
}
namespace ConsoleApp13_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base[] bases = new Base[4];
            bases[0]=new Base();
            bases[1]=new Derived1();
            bases[2]=new Derived2();
            bases[3]=new Derived3();

            foreach(Base b in bases)
            {
                b.show();
            }


            Console.ReadKey();
        }
    }
}
