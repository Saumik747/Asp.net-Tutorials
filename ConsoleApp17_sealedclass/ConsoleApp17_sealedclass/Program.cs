using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//structs are sealed implicitly (Can't be inherited)

#region baseclass 
/*sealed*/
class Base
{
    public virtual void show() 
    {
        Console.WriteLine("this is sealed class and hence cant be inherited");
    }

    
}



class derived : Base
{
    public sealed override  void show()
    {
        Console.WriteLine("this is final overriden behaviour of show and henceforth will be called ");
    }
}

//class derived1:derived
//{
//    public sealed override void show()
//    {

//    }
//}
#endregion 

namespace ConsoleApp17_sealedclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Base b=new Base();
            //b.show();

            derived d = new derived();
            d.show();
            Console.ReadKey();
        }
    }
}
