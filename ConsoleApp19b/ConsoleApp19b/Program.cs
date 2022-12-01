using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public delegate bool IsPassedWithGraceMarks(Students students);
public class Students
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Marks { get; set; }

    public static void PasswithGraceMarks(List<Students> studlist, IsPassedWithGraceMarks isgracable1)
    {


        foreach (Students student in studlist)
        {
            if (isgracable1(student))
            {
                student.Marks += 6;
                Console.WriteLine("ID:{0}  Name:{1}  Student with {2} marks passed with 6 grace mark range", student.Id, student.Name, student.Marks);
            }
        }
    }
}
namespace ConsoleApp19b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students1 = new List<Students>();
            students1.Add(new Students() { Id = 101, Name = "Saumik Dutta", Marks = 77 });
            students1.Add(new Students() { Id = 102, Name = "Karishma tanna", Marks = 37 });
            students1.Add(new Students() { Id = 103, Name = "sanjay sharma", Marks = 29 });
            students1.Add(new Students() { Id = 104, Name = "shreya mhatre", Marks = 39 });
            students1.Add(new Students() { Id = 105, Name = "gaurav sethi", Marks = 31 });


            IsPassedWithGraceMarks IsGracable = new IsPassedWithGraceMarks(isgracable);
            Students.PasswithGraceMarks(students1, IsGracable);



            ///
            List<Students> students2 = new List<Students>();
            students2.Add(new Students() { Id = 301, Name = "Saumik ", Marks = 21 });
            students2.Add(new Students() { Id = 302, Name = "Karishma ", Marks = 23 });
            students2.Add(new Students() { Id = 303, Name = "sanjay ", Marks = 29 });
            students2.Add(new Students() { Id = 304, Name = "shreya J", Marks = 33 });
            students2.Add(new Students() { Id = 305, Name = "gaurav bane", Marks = 22 });
            Console.WriteLine("Gracemark range from 21-24");
            //replacing delegate call with lambda expression
            //=> is lamba operator
            //(input-obj)=>expression
            //
            //

            //IsPassedWithGraceMarks IsGracable1 = new IsPassedWithGraceMarks(isgracable);
            Students.PasswithGraceMarks(students2,Students=> Students.Marks>=21 && Students.Marks < 25);

            Console.ReadKey();
        }



        public static bool isgracable(Students students)
        {
            if (students.Marks >= 29 && students.Marks < 35)
                return true;
            else
                return false;
        }

    }
}
