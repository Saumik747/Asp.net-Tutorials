using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//enum are strongly typed constants
public enum days
{
    monday,
    tuesday,
    wednesday,
    thursday,
    friday,
    saturday,
    sunday
}

//public enum b1:Boolean
//{

//}

public enum button:long //explicity specify data types
{
    dst=7304053115,
    eco,
    fin,
    ops,
    marks,
    //ON,
    //OFF,
}

public enum Electivesubject
{
    webTech,
    RPogramming,
    AdvancedJava,
    python,
    AIMl
}


class student
{
    public string Name { get; set; }
    public Electivesubject subject { get; set; }
}

namespace ConsoleApp18_enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in Enum.GetValues(typeof(days)))
                Console.WriteLine(arg);

            foreach (var arg in Enum.GetValues(typeof(days)))
                Console.WriteLine(arg);

            int[] enumval = (int[])Enum.GetValues(typeof(days));


            Console.WriteLine("printing int value of string");
            foreach (int val in enumval)
            {
                Console.WriteLine(val);
            }

           

            student[] stu = new student[3];
            //using enum value as a constant to pass as a value
            stu[0] = new student { Name = "saumik", subject = Electivesubject.python };
            stu[1] = new student { Name = "defg", subject = Electivesubject.AIMl };
            stu[2] = new student { Name = "mnop", subject = Electivesubject.webTech };
           // stu[2] = new student { Name = "wxyz", subject = Electivesubject.AdvancedJava };

            foreach(student s in stu)
            {
                Console.WriteLine("name:{0} opted subject{1}",s.Name,s.subject);
            }


            //Console.WriteLine(button.ON);
            Console.ReadKey();
        }
    }
}
