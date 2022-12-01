using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23_queue_stack
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
            //Stack<int> stack = new Stack<int>();
            //stack.Push(11);
            //stack.Push(12);
            //stack.Push(13);
            //stack.Push(14);
            //stack.Push(15);


            //foreach (var v in stack)
            //    Console.WriteLine(v);
            //Console.WriteLine("Peek position is:{0}", stack.Peek());

            //stack.Pop();
            //Console.WriteLine("Peek position is:{0}", stack.Peek());

            //stack.Pop();
            //Console.WriteLine("Peek position is:{0}", stack.Peek());

            //int[] arr = stack.ToArray();
            //foreach (var v in arr)
            //    Console.WriteLine(v);


            //Console.WriteLine("check if item 15 exist:{0}", stack.Contains(15));
            //Console.WriteLine("check if item 15 exist:{0}", stack.Contains(1));
            //Console.ReadKey();




            //queue
           // Queue<int> q = new Queue<int>();
           // q.Enqueue(111);
           // q.Enqueue(112);
           // q.Enqueue(113);
           // q.Enqueue(114);
           // q.Enqueue(115);
           // q.Enqueue(116);

           // Console.WriteLine("queue contains ");
           // foreach (var v in q)
           //     Console.WriteLine(v);

           // Console.WriteLine("Peek position is:{0}", q.Peek());
           // q.Dequeue();
            
           // Console.WriteLine("Peek position is:{0}", q.Peek());
           // q.Dequeue();

           // foreach (var v in q)
           //     Console.WriteLine(v);

           // Console.WriteLine("After ToArray()");
           //int[] s = q.ToArray();


           // Console.WriteLine(s);


            //dictionary
            Dictionary<string,long> phoneDirectory=new Dictionary<string,long>();

            phoneDirectory.Add("A",5646554411);
            phoneDirectory.Add("B",5646554422);
            phoneDirectory.Add("C",5646554433);
            phoneDirectory.Add("D",5646554444);
            phoneDirectory.Add("E",5646554455);
            phoneDirectory.Add("F",5646554466);

            foreach(KeyValuePair<string,long> entry in phoneDirectory)
            {
                Console.WriteLine("Key:{0}  value:{1}",entry.Key,entry.Value);
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine("Enter name to search phone number: ");
            var name=Console.ReadLine();
            foreach (KeyValuePair<string, long> entry in phoneDirectory)
            {
                //if(phoneDirectory.ContainsKey(name))
                //{
                //    Console.WriteLine("Search result key:{0} phone no:{1}",name,phoneDirectory[name] );
                //    break;
                //}
                long res = 0;
                if (phoneDirectory.TryGetValue(name, out res))
                {
                    //phoneDirectory.TryGetValue(name, out res);
                    Console.WriteLine("Search result key:{0} phone no:{1}", name, res);
                    break;
                }
                else
                {
                    Console.WriteLine("no record found");
                }
            }


            //for student
            List<Students> students1 = new List<Students>();
            students1.Add(new Students() { Id = 101, Name = "Saumik Dutta", Marks = 77 });
            students1.Add(new Students() { Id = 102, Name = "Karishma tanna", Marks = 37 });
            students1.Add(new Students() { Id = 103, Name = "sanjay sharma", Marks = 29 });
            students1.Add(new Students() { Id = 104, Name = "shreya mhatre", Marks = 39 });
            students1.Add(new Students() { Id = 105, Name = "gaurav sethi", Marks = 31 });


            Console.ReadKey();
        }
    }
}
