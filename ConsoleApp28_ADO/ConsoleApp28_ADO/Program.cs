using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp28_ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connect=@"Data Source=.\sqlexp03;Initial Catalog=mca;Integrated Security=True;Pooling=False";
            SqlConnection conn = new SqlConnection(connect);
conn.Open();
SqlCommand sqlCommand = new SqlCommand("select * from emp", conn);
SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
while (sqlDataReader.Read())
{
Console.WriteLine("ID : {0}, Name :{1}, Gender: {2}, Email: {3}, city: {4}",sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2),
sqlDataReader.GetString(3), sqlDataReader.GetString(4),);
}
sqlDataReader.Close();
conn.Close();
            Console.ReadKey();
        }
    }
}
/*
 //step 1 : get the connection string
//@ -> verbatilator
string conString = @"Data Source=.\sqlexpress01;Initial
Catalog=students;Integrated Security=True;Pooling=False";
//step2 : create sqlconnection object and pass connection string
SqlConnection conn = new SqlConnection(conString);
//step 3 : open the sqlconnection
conn.Open();
//step 4:
//SqlCommand cmd = conn.CreateCommand();
//or
SqlCommand sqlCommand = new SqlCommand("select * from
employee", conn);
//step 5 : execute sql command
//exectue sacla - group by
//execute reader - select
//execute select - inset , updat and delete
SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
while (sqlDataReader.Read())
{
Console.WriteLine("ID : {0}, Name :{1}, Gender: {2}, Email:
{3}, dept: {4}, city: {5}",sqlDataReader.GetInt32(0),
sqlDataReader.GetString(1), sqlDataReader.GetString(2),
sqlDataReader.GetString(3), sqlDataReader.GetString(4),
sqlDataReader.GetString(5));
}
sqlDataReader.Close();
conn.Close();
 
 */