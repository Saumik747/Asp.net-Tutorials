using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp19a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students1 = new List<Students>();
            students1.Add(new Students() { Id=101,Name="Saumik Dutta",Marks=77});
            students1.Add(new Students() { Id=102,Name="Karishma tanna",Marks=37});
            students1.Add(new Students() { Id=103,Name="sanjay sharma",Marks=29});
            students1.Add(new Students() { Id=104,Name="shreya mhatre",Marks=39});
            students1.Add(new Students() { Id=105,Name="gaurav sethi",Marks=19});

            //students1.PasswithGraceMarks(students1, isgracable);
            // Students.PasswithGraceMarks(students);
            // IsPassedWithGraceMarks IsGracable = new IsPassedWithGraceMarks();

            IsPassedWithGraceMarks isGracable = new IsPassedWithGraceMarks(isgracable);
            students1.PasswithGraceMarks(students1, isGracable);
            Console.ReadKey();
        }

        public bool isgracable(Students students)
        {
            
            
                if (students.Marks >= 29 && students.Marks < 35)
                    return true;
                

                
                
            
            return false;
        }
    }
}

public delegate bool IsPassedWithGraceMarks(Students students);
public class Students
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Marks { get; set; }

    public static void PasswithGraceMarks(List<Students> studlist, IsPassedWithGraceMarks isgracable1)
    {
       foreach(Students student in studlist)
        {
            if(student.Marks>=29 && student.Marks<35)
            {
                student.Marks += 6;
                Console.WriteLine("ID:{0}  Name:{1}  Student with {2} marks passed with 6 grace mark range",student.Id,student.Name,student.Marks);
            }
        }
    }
}