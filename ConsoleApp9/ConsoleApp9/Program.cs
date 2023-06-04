using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//structures in c#


class A
{
    int x = 5;
    int y = 10;
}

public struct MCA
{
   // public static int X=10;
   // public static int Y = 10;
    public  int X;
    public  int Y;


    public MCA(int i,int j)
    {
        X = i;
        Y = j;
    }
    public void show()
    {
        Console.WriteLine("Method of Struct {0}  {1}",X,Y);
    }
}


public class employee
{
    //fields
    /*  public int age;
      public int empid;
      public string empname;

      public employee(int empid,string empname,int age)
      {
          this.age = age; 
          this.empid = empid;
              this.empname = empname;

      }
     public int age=22;
    public int empid=101;
    public string empname="Saumik";

    */
    private int deptid; //cannot be negative or 0 and should be readonly
    private int empid; //cannot be nagatiuve or 0
    private string empname; //cannot be empty or 0

    //using getter and setter methods to access values

    public void setEmpname(string empname)
    {
        this.empname = string.IsNullOrEmpty(empname)|| string.IsNullOrWhiteSpace(empname) ? throw new Exception("Name cannot be empty or null") :this.empname=empname;
      
      /*  if (string.IsNullOrEmpty(empname))
        {
            throw new Exception("name cannot be empty or null");
        }

        else
        {
            this.empname = empname;
        }*/
    }

    // using properties instead of getter and setter methods directly
    //use value keyword when using this type of get and set method
    public int Empid
    { set { this.empid = empid <= 0 ? throw new Exception("id cannot be negative or 0") : this.empid = value; } get { return empid; }  }

   public string Empname
    { set { this.empname = string.IsNullOrEmpty(empname) ? throw new Exception(empname) : this.empname = value; } get { return empname; } }
    
    public int Deptid
    { get { return 1701; }  }
    public void setEmpid(int empid)
    {
        this.empid = empid<=0 ? throw new Exception("id cannot be negative or 0") : this.empid = empid; 
      /*  if (empid <= 0)
        {
            throw new Exception("id cannot be negative or 0");
        }

        else
        { 
            this.empid = empid;
        }
      */
    }

    /*
    public void setEmpdeptid(int deptid)
    {
        if (deptid <= 0)
        {
            throw new Exception("deptid cannot be negative or 0 and should be readonly");
        }

        else
        {
            this.deptid = deptid;
    }
    }
    */


    public int getEmpid()
    {
        return this.empid;
    }


    //when no setter method is provifded the field becomes readonly
    //when no getter method is provided the field becomes writeonly
    public int getEmpdeptid()
    {
        return 1701;
    }


    public string getEmpname()
    {
        return this.empname;
    }

    public void show()
  {
    //  Console.WriteLine("Name:{0}  deptid:{1}  empid:{2}",empname,deptid,empid );
      Console.WriteLine("Show method inside emp->show()\nName:{0}  deptid:{1}  empid:{2}\n", getEmpname(),getEmpdeptid(),getEmpid() );
      Console.WriteLine("Show method inside emp->show()\nName:{0}  deptid:{1}  empid:{2}\n", Empname,Deptid,Empid );
    
  }

}
namespace ConsoleApp9
{

  internal class Program
  {
      static void Main(string[] args)
      {
          // MCA mca = new MCA(10,20);
          // MCA mca = new MCA(sn);
          // mca.show();


          //parameterised constrtuctor
         // employee emp = new employee(101, "saumik", 22);
          employee emp = new employee();
           // emp.setEmpdeptid(1);
            emp.setEmpname("Saumik ");
            emp.setEmpid(101);
          emp.show();
            Console.WriteLine("outside show method in main method\nName:{0}  deptid:{1}  empid:{2}\n", emp.getEmpname(), emp.getEmpdeptid(), emp.getEmpid());
            emp.Empid = 102;
            emp.Empname = "Saumik1";
          
            Console.WriteLine("outside show method in main method\nName:{0}  deptid:{1}  empid:{2}\n", emp.Empname, emp.Deptid, emp.Empid);

            Console.ReadKey();
      }
  }
}
