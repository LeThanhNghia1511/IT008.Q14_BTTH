using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class MyDirectory
    {
        private string strPath;

        public MyDirectory(string strPath = "")
        {
            this.strPath = strPath;
        }

        public void Input()
        {
            Console.Write("Nhap duong dan thu muc: ");
            this.strPath = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine("Duong dan thu muc: {0}", strPath);
        }

        public void GetDirectoryAndFile()
        {
            if (Directory.Exists(strPath))
            {
                string[] files = Directory.GetFiles(strPath);
                string[] directories = Directory.GetDirectories(strPath);

                // In cac file
                if (files.Length != 0)
                {
                    Console.WriteLine();
                    foreach (var file in files)
                    {
                        Console.WriteLine(file);
                    }
                }
                else
                {
                    Console.WriteLine("Khong co file nao trong thu muc.");
                }

                // In cac thu muc con
                if (directories.Length != 0)
                {
                    Console.WriteLine();
                    foreach (var directory in directories)
                    {
                        Console.WriteLine(directory);
                    }
                }
                else
                {
                    Console.WriteLine("Khong co thu muc con nao trong thu muc.");
                }

            }
            else
            {
                Console.WriteLine("Duong dan thu muc khong ton tai.");
            }
        }
    }
}
