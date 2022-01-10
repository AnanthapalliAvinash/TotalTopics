using System.Text;
using System.IO;

namespace FileStreamWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string fpath = @"E:\Test.txt";
            // Delete file if exists
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            using (FileStream fs = File.Create(fpath))
            {
                AddTexttoFile(fs, "Hi");
                AddTexttoFile(fs, "\r\nWelcome to Tutlane");
                AddTexttoFile(fs, "\r\nFileStream Example");
            }
            // Create the file
            using (TextWriter wr = File.CreateText(fpath))
            {
                wr.WriteLine("Hi");
                wr.WriteLine("\r\nWelcome to Tutlane12345");
                wr.WriteLine("\r\nTextWriter Example123456");
            }


            //binary writer
            using (BinaryWriter bw = new BinaryWriter(File.Open(fpath, FileMode.Create)))
            {
                bw.Write(1.25);
                bw.Write("Welcome to Tutlane");
                bw.Write(10);
                bw.Write(true);
                bw.Write("test");
            }
            static void AddTexttoFile(FileStream fs, string value)
            {
                byte[] info = new UTF8Encoding(true).GetBytes(value);
                fs.Write(info, 0, info.Length);
            }
        }
    }
}