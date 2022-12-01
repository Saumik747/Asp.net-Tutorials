using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
//required to serialize and deserialize objects

namespace ConsoleApp27_serializationdeserialization
{
    internal class Program
    {
        //serialization and deserialization
        static void Main(string[] args)
        {
            /*
             * step1:- using System.Runtime.Serialization
             * using System.Runtime.Serialization.Formatters.Binary;
             * create serializable class student
             * create objects of serializable class
             * serialize (write into file) and deserialize(read from file_
             * students objects
             * */

            Student[] students = new Student[]
            {
             new Student(){  Id = 101, Name = "Saumik Dutta", email="saumik@gmail.com" },
             new Student(){  Id = 102, Name = "Akshay Shetty", email="akshetty@gmail.com" },
             new Student(){  Id = 103, Name = "sanjay dewan", email="dewansanjay@gmail.com" }
            };



            serializestudent(students);
            deserializestudent();
            Console.ReadKey();
        }

        static void serializestudent(Student[] students)
        {
            //string file = @"D:\visual studio\file_handling\studentdata.dat";
            string file = @"D:\visual studio\file_handling\studentdata.txt";
            FileStream fs=new FileStream(file, FileMode.Create);    

            BinaryFormatter binaryformatter = new BinaryFormatter();
            foreach (Student student in students)
            {
               binaryformatter.Serialize(fs, student);
            }

            fs.Close();
            Console.WriteLine("Serialization completed!!!");



        }


        static void deserializestudent()
        {
            //string file = @"D:\visual studio\file_handling\studentdata.dat";
            string file = @"D:\visual studio\file_handling\studentdata.txt";
            FileStream fs = new FileStream(file, FileMode.Open);

            BinaryFormatter binaryformatter = new BinaryFormatter();
            List<Student> students = new List<Student>();
            while(fs.Position!=fs.Length)
            {
                students.Add((Student)binaryformatter.Deserialize(fs));
            }
            foreach (Student student in students)
            {
                Console.WriteLine("Id:{0} Name:{1} Email:{2}", student.Id,student.Name,student.email);
            }

            fs.Close();
            Console.WriteLine("DeSerialization completed!!!");



        }
    }

    [Serializable]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string email { get; set; }
            
    }
  }
