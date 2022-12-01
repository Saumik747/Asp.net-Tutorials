using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16_partialclass
{
    //internal class Class2
    //{
    //}

   partial class exam
    {
        private string subject;

        public exam(int cid,string cname,string sub)
        {
            this.center_id = cid;
            this.center_name= cname;
            this.subject = sub;
        }
        partial void print()
        {
            Console.WriteLine("defining the partial method");
        }
    }
}
