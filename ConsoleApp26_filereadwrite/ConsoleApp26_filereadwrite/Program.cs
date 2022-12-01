using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp26_filereadwrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //file read write using various classes



            // filestreamwr();
            //  filestreamread();
            //streamwriterwr();
            //streamreaderread();


            //textwriterwr();
            //txread();

            //binarywriter();
            //binaryreader();

            stringwr();
            Console.ReadKey();
        }

        //Writing and reading file with File Stream class

        static void filestreamwr()
        {
            string filename = @"D:\visual studio\file_handling\filehandle.txt";
            //var text = "hello";

            FileStream filestream = new FileStream(filename, FileMode.OpenOrCreate);

            for (int i = 65; i <= 90; i++)
            {
                filestream.WriteByte((byte)i);
                filestream.WriteByte((byte)i);

            }
            //byte[] bytes1 = Encoding.UTF8.GetBytes(text);
            //filestream.Write(bytes1, 0, bytes1.Length);


            filestream.Flush();
            filestream.Close();
            Console.WriteLine("File is created and Data is written");

        }

        static void filestreamread()
        {
            string filename = @"D:\visual studio\file_handling\filehandle.txt";
            var text = "Hello";

            FileStream filestream = new FileStream(filename, FileMode.OpenOrCreate);
            int i;

            while ((i = filestream.ReadByte()) != -1)
            {
                //Console.Write((char)i);
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\nEnd of file");
        }

        //write and read with stream writer
        static void streamwr()
        {
            string filename = @"D:\visual studio\file_handling\filehandle_stream.txt";
            FileStream filestream = new FileStream(filename, FileMode.OpenOrCreate);

            //accepts the obj of filestream to read and write
            StreamWriter streamWriter = new StreamWriter(filestream);
            streamWriter.WriteLine("Hello and we are using streamwriter111");

            // filestream.Flush();

            streamWriter.Flush();
            streamWriter.Close();
            filestream.Close();
            Console.WriteLine("File is modified");
        }

        static void streamread()
        {
            string filename = @"D:\visual studio\file_handling\filehandle_stream.txt";
            FileStream filestream = new FileStream(filename, FileMode.OpenOrCreate);

            StreamReader streamReader = new StreamReader(filestream);
            string data = streamReader.ReadToEnd();


            Console.WriteLine(data);
            filestream.Flush();
            filestream.Close();

            Console.WriteLine("File Contents");



        }


        //Read/Writer with textwriter
        static void textwriterwr()
        {
            string filename = @"D:\visual studio\file_handling\filehandle_textwr.txt";

            TextWriter teamwriter = File.CreateText(filename);

            teamwriter.WriteLine("hello and writing with textwriter");
            teamwriter.Close();
            Console.WriteLine("textwriter called");

        }

        static void txread()
        {
            string filename = @"D:\visual studio\file_handling\filehandle_textwr.txt";


            TextReader txtreader = File.OpenText(filename);

            Console.WriteLine(txtreader.ReadToEnd());
            txtreader.Close();

        }

        //binarywriter and binaryreader
        static void binarywriter()
        {
            string filename = @"D:\visual studio\file_handling\filehandle_bin.dat";
            FileStream filestream = new FileStream(filename, FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(filestream);
            bw.Write(1701);
            bw.Write(true);
            bw.Write("Saumik Dutta");
            bw.Write(783264.11);

            bw.Flush();
            bw.Close();
            filestream.Close();
            Console.WriteLine("binary Writer called");
        }


        static void binaryreader()
        {
            string filename = @"D:\visual studio\file_handling\filehandle_bin.dat";
            FileStream filestream = new FileStream(filename, FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(filestream);

            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadBoolean());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadDouble());


            filestream.Close();
        }


        //read write string writer
        static void stringread()
        {

        }

        static void stringwr()
        {
            //string filename = @"D:\visual studio\file_handling\filehandle_string.txt";
            //FileStream filestream = new FileStream(filename, FileMode.OpenOrCreate);

            string data = "Welcome to the stringwriteclass\n" +
                "Second line of Data\n" +
                "third line of Data";

            StringBuilder stringbulder=new StringBuilder();
            StringWriter sw=new StringWriter(stringbulder);

            sw.WriteLine(data);
            sw.Flush();
            sw.Close();

            Console.WriteLine("end of line");

            StringBuilder sb=new StringBuilder();
            StringReader sr = new StringReader(sw.ToString());

            while(sr.Peek()>-1)
            {
                Console.WriteLine(sr.ReadToEnd());
            }


         //
        }


    }
}
