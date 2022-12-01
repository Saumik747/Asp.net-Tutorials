using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22_list
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Marks { get; set; }

    }
        internal class Program
    {
        static void Main(string[] args)
        {
            List<string> subjects = new List<string>();
            subjects.Add("Webtech2");
            subjects.Add("python");
            subjects.Add("AIML");
            subjects.Insert(0,"MCA Subject List:");


            List<int> sub_code = new List<int>();
            sub_code.Add(101);
            sub_code.Add(102);
            sub_code.Add(103);


            Console.WriteLine("Capacity of subject list  is {0}",subjects.Capacity);
            Console.WriteLine("Capacity of sub_code list  is {0}",sub_code.Capacity);


            /*traversing through list
             * method 1: using for loop
             * 
             * */
            for (int i = 0; i < subjects.Count; i++)
            {
                Console.WriteLine("List item:{0} : {1}", i, subjects[i]);
            }
            /*for(int i = 0; i < subjects.Count;i++)
            {
                Console.WriteLine("List item:{0} : {1}", i, subjects[i]);
            }*/
            //for loop not standard due to probability of out of range exception


            //method 2: using foreach loop - standard
            Console.WriteLine("\nSubjects code are");
            foreach(var v in sub_code)
            {
                Console.WriteLine("sub_code :{0}",v);
            }


            //method 3: ForEach Mthod of List class
            Console.WriteLine("\nmethod 3: ForEach Mthod of List class");
            subjects.ForEach(subject => Console.WriteLine("subjects_a: {0}",subject));


            //Method 4: compacting ForEach method of list class
            Console.WriteLine("\nMethod 4: compacting ForEach method of list class");
            subjects.ForEach(Console.WriteLine);


            //Method 5: using string.join()
            Console.WriteLine("\nMethod 5: using string.join()");
            Console.WriteLine(String.Join("\n", subjects));



            Console.WriteLine("for student list");
            List<Students> students1 = new List<Students>();
            students1.Add(new Students() { Id = 101, Name = "Saumik Dutta", Marks = 77 });
            students1.Add(new Students() { Id = 102, Name = "Karishma tanna", Marks = 37 });
            students1.Add(new Students() { Id = 103, Name = "sanjay sharma", Marks = 29 });
            students1.Add(new Students() { Id = 104, Name = "shreya mhatre", Marks = 39 });
            students1.Add(new Students() { Id = 105, Name = "gaurav sethi", Marks = 19 });


            for (int i = 0; i < students1.Count; i++)
            {
                Console.WriteLine("List item:{0} : {1}", i, students1[i]);
            }
            /*for(int i = 0; i < subjects.Count;i++)
            {
                Console.WriteLine("List item:{0} : {1}", i, subjects[i]);
            }*/
            //for loop not standard due to probability of out of range exception


            //method 2: using foreach loop - standard
            Console.WriteLine("\n List of Students");
            foreach (Students v in students1)
            {
                Console.WriteLine("id :{0} name:{1} marks:{2}", v.Id,v.Name,v.Marks);
            }


            //method 3: ForEach Mthod of List class
            Console.WriteLine("\nmethod 3: ");
            students1.ForEach(Students => Console.WriteLine("id :{0} name:{1} marks:{2}", Students.Id, Students.Name, Students.Marks));


            //Method 4: compacting ForEach method of list class
            Console.WriteLine("\nMethod 4: ");
            students1.ForEach(Console.WriteLine);
           // students1.


            //Method 5: using string.join()
            Console.WriteLine("\nMethod 5: ");
            Console.WriteLine(String.Join("\n",students1 ));


            Console.ReadKey();

        }
    }
}
