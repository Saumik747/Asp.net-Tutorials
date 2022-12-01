using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16_partialclass
{
    //internal class Class3
    //{
    //}


    partial class exam
    {

        partial void print();
        
        public void show()
        {
            Console.WriteLine("Your center id:{0} " +
                "center name:{1} " +
                "subject:{2}", this.center_id, this.center_name, this.subject);
            print();
            
                    

            /*
             * partial methods
             * 1.implicitly proivate
             * 2.can have only void as return type
             * 3.can be static or generic
             * 4.declaration and definition can be in
             * same or different files
             * 
             * 
             */
        }

    }
}
