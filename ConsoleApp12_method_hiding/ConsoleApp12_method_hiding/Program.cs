using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Base
{
    public void show()
    {
        Console.WriteLine("base class -show()");
    }
}

class Derived : Base
{   
    //method hiding 
    //using new keyword is optional but usage is standard
    public new void show()
    {
        //base.show();//calling default behavious of base
                    //class show method
        Console.WriteLine("Derived class -show()");
    }   
}

namespace ConsoleApp12_method_hiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived d=new Derived();
            //d.show();

            //base class refernece variable to refer to  base class and accessing derived class
            Base b =new Derived();
            //b.show();

            ((Base)b).show();//typecasting methods to access b to base type
            Console.ReadKey();
        }
    }
}
