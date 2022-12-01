using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/// <summary>
/// Fuile retrieving information about drive directory and files
/// system.io provides 3 information classsess
/// Driveinfo
/// </summary>
namespace ConsoleApp25_filehandling
{
    public class DriveA
    {
        public static DriveInfo[] driveInfo = DriveInfo.GetDrives();
        public static string file;
        
        
        public static void Createfoldr()
        {
            //Console.WriteLine("Enter directory name to create : ");
            //var dir = Console.ReadLine();

            //if (!Directory.Exists(dir))
            //{
            //    Directory.CreateDirectory(dir);
            //    Console.WriteLine("Dir Created Successfully! ");
            //}

            //else
            //{
            //    Console.WriteLine("Directory already exists");
            //    Console.WriteLine("Enter Filename to create");
            //    String filename = Console.ReadLine();

            //    var path = Path.Combine(dir, filename);
            //    if (!File.Exists(path))
            //    {
            //        File.Create(path);
            //        Console.WriteLine("File Created:{0}", path);
            //    }
            //    else
            //    {
            //        Console.WriteLine("File Already Exits");
            //    }

            //}
        }


        public static void infodir()
        {
           // DriveInfo[] driveInfo = DriveInfo.GetDrives();
            foreach (DriveInfo drive in driveInfo)
            {
                Console.WriteLine(drive.Name);
            }


            //Console.WriteLine("Enter the drive name to know more: ");
            //string drive1 = Console.ReadLine();

            //DriveInfo driveinfo1 = new DriveInfo(drive1);
            //Console.WriteLine("Name:{0} ", driveinfo1.Name);
            //Console.WriteLine("DriveType:{0} ", driveinfo1.DriveType);
            //Console.WriteLine("DriveFormat:{0} ", driveinfo1.DriveFormat);
            //Console.WriteLine("Volume Label:{0} ", driveinfo1.VolumeLabel);
            //Console.WriteLine("TotalSize:{0} ", driveinfo1.TotalSize / 1073741824 + "GB");
            //Console.WriteLine("TotalFreeSpace:{0} ", driveinfo1.AvailableFreeSpace / 1073741824 + "GB");
            //Console.WriteLine("driveinfo1.IsReady:{0} ", driveinfo1.IsReady);
            //Console.WriteLine("RootDirectory:{0} ", driveinfo1.RootDirectory);
            //Console.WriteLine("driveinfo1.GetType().FullName:{0} ", driveinfo1.GetType().FullName);

        }

        public static void driveinfoa()
        {
            Console.WriteLine("Enter the drive name to know more: ");
            string drive2 = Console.ReadLine();
            DirectoryInfo directory1 = new DirectoryInfo(drive2);
            Console.WriteLine("Name:{0}", directory1.Name);
            Console.WriteLine("FullName:{0}", directory1.FullName);
            Console.WriteLine("Parent:{0}", directory1.Parent);
            Console.WriteLine("Attributes:{0}", directory1.Attributes);
            Console.WriteLine("CreationTime:{0}", directory1.CreationTime);
            Console.WriteLine("Extension:{0}", directory1.Extension);
            Console.WriteLine("Last Accessed Time:{0}", directory1.LastAccessTime);

            DirectoryInfo[] subdirectories = directory1.GetDirectories();
            Console.WriteLine("\nSubDirectory: ");

            foreach (DirectoryInfo subdirectory in subdirectories)
            {
                Console.WriteLine("{0}", subdirectory.Name);
            }

            FileSystemInfo[] directory2 = directory1.GetFileSystemInfos();
            foreach (FileSystemInfo fsi in directory2)
            {
                Console.WriteLine("{0}", fsi.Name);
            }



            Console.WriteLine("Last Accessed Time:{0}", directory1.LastAccessTime);
        }

        public static void getFileInfo()
        {
            Console.WriteLine("Enter the filepath to know more about");
            file=Console.ReadLine();
            FileInfo fileInfo = new FileInfo(file);
            Console.WriteLine("Name:{0}",fileInfo.Name);
            Console.WriteLine("FullName:{0}", fileInfo.FullName);
            Console.WriteLine("Length:{0}", fileInfo.Length);
            Console.WriteLine("CreationTime:{0}", fileInfo.CreationTime);
            Console.WriteLine("DirectoryName:{0}", fileInfo.DirectoryName);
            Console.WriteLine("Attributes:{0}", fileInfo.Attributes);
            Console.WriteLine("Extension:{0}", fileInfo.Extension);
            Console.WriteLine("fileInfo.GetType().Name:{0}", fileInfo.GetType().Name);
            Console.WriteLine("LastAccessTime:{0}", fileInfo.LastAccessTime);
            
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter directory name to create : ");
            //var dir = Console.ReadLine();

            //if (!Directory.Exists(dir))
            //{
            //    Directory.CreateDirectory(dir);
            //    Console.WriteLine("Dir Created Successfully! ");
            //}

            //else
            //{
            //    Console.WriteLine("Directory already exists");
            //    Console.WriteLine("Enter Filename to create");
            //    String filename = Console.ReadLine();

            //    var path = Path.Combine(dir, filename);
            //    if (!File.Exists(path))
            //    {
            //        File.Create(path);
            //        Console.WriteLine("File Created:{0}", path);
            //    }
            //    else
            //    {
            //        Console.WriteLine("File Already Exits");
            //    }

            //}


            DriveInfo[] driveInfo = DriveInfo.GetDrives();
            foreach (DriveInfo drive in driveInfo)
            {
                Console.WriteLine(drive.Name);
            }


            //Console.WriteLine("Enter the drive name to know more: ");
            //string drive1 = Console.ReadLine();

            //DriveInfo driveinfo1 = new DriveInfo(drive1);
            //Console.WriteLine("Name:{0} ", driveinfo1.Name);
            //Console.WriteLine("DriveType:{0} ", driveinfo1.DriveType);
            //Console.WriteLine("DriveFormat:{0} ", driveinfo1.DriveFormat);
            //Console.WriteLine("Volume Label:{0} ", driveinfo1.VolumeLabel);
            //Console.WriteLine("TotalSize:{0} ", driveinfo1.TotalSize / 1073741824 + "GB");
            //Console.WriteLine("TotalFreeSpace:{0} ", driveinfo1.AvailableFreeSpace / 1073741824 + "GB");
            //Console.WriteLine("driveinfo1.IsReady:{0} ", driveinfo1.IsReady);
            //Console.WriteLine("RootDirectory:{0} ", driveinfo1.RootDirectory);
            //Console.WriteLine("driveinfo1.GetType().FullName:{0} ", driveinfo1.GetType().FullName);


            //Console.WriteLine("Enter the drive name to know more: ");
            //string drive2 = Console.ReadLine();
            //DirectoryInfo directory1 = new DirectoryInfo(drive2);
            //Console.WriteLine("Name:{0}", directory1.Name);
            //Console.WriteLine("FullName:{0}", directory1.FullName);
            //Console.WriteLine("Parent:{0}", directory1.Parent);
            //Console.WriteLine("Attributes:{0}", directory1.Attributes);
            //Console.WriteLine("CreationTime:{0}", directory1.CreationTime);
            //Console.WriteLine("Extension:{0}", directory1.Extension);
            //Console.WriteLine("Last Accessed Time:{0}", directory1.LastAccessTime);

            //DirectoryInfo[] subdirectories = directory1.GetDirectories();
            //Console.WriteLine("\nSubDirectory: ");

            //foreach(DirectoryInfo subdirectory in subdirectories)
            //{
            //    Console.WriteLine("{0}",subdirectory.Name);
            //}

            //FileSystemInfo[] directory2 = directory1.GetFileSystemInfos();
            //foreach(FileSystemInfo fsi in directory2)
            //{
            //    Console.WriteLine("{0}",fsi.Name);
            //}



            //Console.WriteLine("Last Accessed Time:{0}", directory1.LastAccessTime);
            //Console.WriteLine("Name:{0}", directory1.Name);





            DriveA.getFileInfo();
            
            
            
            
            
            
            Console.ReadKey();

        }
    }
}
