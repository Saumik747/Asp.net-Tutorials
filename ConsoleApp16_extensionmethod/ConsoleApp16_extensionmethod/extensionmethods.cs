using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16_extensionmethod
{
    static class extensionmethods
    {
        //enstionsion method of mca class
        //this mca m - binding paramter
        //biniding parameter should be always
        //at firstplace in formal paramter of list order
        //extension class should be top level static class
        //extension methods should be public static <method_name>
        public static void method4(this MCA m)
        {
            Console.WriteLine("extension method-Method4() call");
        }

        public static void method5( string name, string dept, this MCA m2)
        {
            Console.WriteLine("extension method-Method5() call");
            Console.WriteLine("Name:{0} dept:{1}",name,dept);
           
         }
    }
}
