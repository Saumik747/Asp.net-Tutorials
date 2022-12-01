using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class A
{
    public void show<T>(T a,T b)
    {
        Console.WriteLine("calling generic method a- {0} b-{1} parameter-{2}",
            a,b,a.GetType().Name);

    }
}
public class GenericClass<T>
{
    public T Name { get; set; }
    public T Id { get; set; }

    public GenericClass(T msg)
    {
        Console.WriteLine("Generic class " +
            "handling type: {0} and value: {1}",
            msg.GetType().Name, msg);
    }



    public void show()
    {
        Console.WriteLine("id:{0}  name:{1}",this.Id,this.Name);
    }

}

namespace ConsoleApp21a_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //GenericClass<int> instance = new GenericClass<int>(12345);
            //GenericClass<long> instance1 = new GenericClass<long>(17236123);
            //GenericClass<string> instance2 = new GenericClass<string>("saumik");


            A a = new A();
            a.show<int>(10, 20);
            a.show<string>("saumik", "dutta");

            //GenericClass<int> instance =new GenericClass<int>();
            //instance.Name = 17019;
            //instance.Id = 1;
            //instance.show();

            //GenericClass<string> instance2 = new GenericClass<string>();
            //instance2.Name = "saumik";
            //instance2.Id = "2";
            //instance2.show();


            Console.ReadKey();

        }
    }
}
