using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp21_index_generics_arraylist
{

    /*
     * arraylist
     * dynamic array with increasing and decreasing capacity (length)
     * can hold any primimtive or user defined type of value
     * */
    internal class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //a[0] = "1st index";
            //a[1] = "2nd index";
            //a[2] = "3rd index";
            //a[3] = "4th index";
            //a[4] = "5th index";

            //Console.WriteLine(a[0]);
            //Console.WriteLine(a[1]);
            //Console.WriteLine(a[2]);
            //Console.WriteLine(a[3]);
            //Console.WriteLine(a[4]);

            ArrayList arrayList = new ArrayList();
            arrayList.Add(111);
            arrayList.Add("this is string value");
            arrayList.Add(4.32f);
            arrayList.Add(123.45);
            arrayList.Add(true);
            arrayList.Add(null);
            //even null is allowed as a value
            arrayList.Add("previous value is null");


            foreach(var arrayListItem in arrayList)
            {
                Console.WriteLine(arrayListItem);
            }
           
           Console.WriteLine("Capacity of arraylist now is {0}",arrayList.Capacity);

            arrayList.Add(112);
            arrayList.Add("this is string value1");
            arrayList.Add(41.32f);
            arrayList.Add(1231.45);
            arrayList.Add(true);
            arrayList.Add(null);
            //even null is allowed as a value
            arrayList.Add("previous value is null  1");
            arrayList.Insert(13,"this is 13th value in arraylist");

            foreach (var arrayListItem1 in arrayList)
            {
                Console.WriteLine(arrayListItem1);
            }

            Console.WriteLine("Capacity of arraylist now is1 {0}",arrayList.Capacity);


            ////arrayList.Clear();
            ////Console.WriteLine("Capacity of arraylist after clear() {0}", arrayList.Capacity);
            //Console.WriteLine("\nafter using RemoveAt function");
            //arrayList.Remove("previous value is null");
            //foreach (var arrayListItem2 in arrayList)
            //{
            //    Console.WriteLine(arrayListItem2);
            //}


            //Console.WriteLine("\nafter using RemoveAt function");
            //arrayList.RemoveAt(1);
            //foreach (var arrayListItem3 in arrayList)
            //{
            //    Console.WriteLine(arrayListItem3);
            //}


            //Console.WriteLine("\nafter using removerange function");
            //arrayList.RemoveRange(0, 10);
            //foreach (var arrayListItem4 in arrayList)
            //{
            //    Console.WriteLine(arrayListItem4);
            //}

            //removing specific value

            arrayList.Remove("previous value is null");

            //removing specific index
            Console.WriteLine("\nafter using remove and RemoveAt function");
            arrayList.RemoveAt(2);
            foreach (var arrayListItem5 in arrayList)
            {
                Console.WriteLine(arrayListItem5);
            }

            //removes values from 7 to 12
            Console.WriteLine("\nafter using removerange function");
            arrayList.RemoveRange(0, 10);
            foreach (var arrayListItem6 in arrayList)
            {
                Console.WriteLine(arrayListItem6);
            }

            Console.ReadKey();
        }
    }

    class A
    {
        private /*static*/ string[] name=new string[10];

        public string this[int i]
        {
            get { return name[i]; }
            set { name[i] = value;}
        
        }



        public  void show()
        {
            Console.WriteLine("show function called");
            foreach(string name1 in name)
                Console.WriteLine(name1);
        }
    }


}
