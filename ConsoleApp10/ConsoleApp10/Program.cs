using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//properties and inheritance
//PropertiesIn_inheritance_polymorphism_static_abstract

class Base
{
    string name;
    string dept;
    static string inst;

    //static properties accessd with class name not object
    public static string Inst
    {
        get { return inst; }
        set { inst = value; }
    }

    //creating readonly property with private set accessor
    public string Dept
    {
        get;
        private set;
    } = "deparment of data science and technology";
    public string Name
    {
        get {
            Console.WriteLine("Base-get");
            return name; } 
        set {
            Console.WriteLine("Base-set");
            name = value; }
    }
}

class Derived : Base
{

}
namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();
            derived.Name = "MCA202123";
            Derived.Inst = "KJ somaiya institute of management";
           // derived.Dept = "";
            Console.WriteLine("name: {0}\nInstitute: {1}\ndept:{2}",derived.Name,Derived.Inst,derived.Dept);
            
            Console.ReadKey();
        }
    }
}
