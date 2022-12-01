using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16_partialclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exam e = new exam(1, "kjsim", "maths");
            e.show();
            Console.ReadKey();
        }
    }
}
