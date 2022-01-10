using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TutlaneExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDetails ud = new UserDetails(1, "Suresh", "Hyderabad");
            Console.WriteLine("Before serialization the object contains: ");
            ud.GetDetails();
            string fpath = @"E:\Test1.txt";
            // Check if file exists
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            //Opens a file and serializes the object into it in binary format.
            Stream stream = File.Open(fpath, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, ud);
            stream.Close();
            Console.WriteLine("\nSerialization Successful");

            //Opens file "Test.txt" and deserializes the object from it.
            stream = File.Open(fpath, FileMode.Open);
            bf = new BinaryFormatter();
            ud = (UserDetails)bf.Deserialize(stream);
            stream.Close();

            Console.WriteLine("");
            Console.WriteLine("After deserialization the object contains: ");
            ud.GetDetails();
            Console.ReadLine();
        }
    }
    [Serializable()]
    public class UserDetails
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string location { get; set; }
        public UserDetails(int id, string name, string place)
        {
            userId = id;
            userName = name;
            location = place;
        }
        public void GetDetails()
        {
            Console.WriteLine("UserId: {0}", userId);
            Console.WriteLine("UserName: {0}", userName);
            Console.WriteLine("Location: {0}", location);
        }
    }
}