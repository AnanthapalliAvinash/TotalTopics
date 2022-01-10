using System;
using System.IO;
using System.Text;

namespace FileStreamRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string fpath = @"E:\Test.txt";
            // Check if file exists
            if (File.Exists(fpath))
            {
                // Open the file and read
                using (FileStream fs = File.OpenRead(fpath))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding encode = new UTF8Encoding(true);
                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                        Console.WriteLine(encode.GetString(b));
                    }
                }
                //Reading a Text in file
                    using (TextReader tr = File.OpenText(fpath))
                    {
                        Console.WriteLine(tr.ReadToEnd());
                    }
                using (BinaryWriter bw = new BinaryWriter(File.Open(fpath, FileMode.Create)))
                {
                    bw.Write(1.25);
                    bw.Write("Welcome to Tutlane");
                    bw.Write(10);
                    bw.Write(true);
                    bw.Write("test");
                }
                // Reading Values by creating BinaryReader instance
                using (BinaryReader br = new BinaryReader(File.Open(fpath, FileMode.Open)))
                {
                    Console.WriteLine(br.ReadDouble());
                    Console.WriteLine(br.ReadString());
                    Console.WriteLine(br.ReadInt32());
                    Console.WriteLine(br.ReadBoolean());
                    Console.WriteLine(br.ReadString());
                }

            }
            Console.ReadLine();
        }
    }
}
