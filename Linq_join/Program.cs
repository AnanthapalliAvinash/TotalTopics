using System;
using System.Collections.Generic;
using System.Linq;
namespace Linq_join
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }
    }
    
    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            List<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };
            List<String> countries = new List<string>() { "indiaa", "chaina", "usa", "aus","japan" };
            String[] result = (from s in countries select s).ToArray();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("************************");
            //partitioning operators in linq
            IEnumerable<string> result4 = (from country in countries select country).Skip(3);
            //IEnumerable<string> result4 = (from country in countries select country).Take(3);
            //IEnumerable<string> result4 = (from country in countries select country).TakeWhile(s=>s.Length >5);
            //IEnumerable<string> result4 = (from country in countries select country).SkipWhile(s => s.Length >5);
            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("****************************");
            //generation operators in linq
            IEnumerable<int> r = Enumerable.Range(1, 10).Where(x=>x%2==0);
            //var r = Enumerable.Repeat("hello",5);
            {
                foreach (var item in r)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();
            Console.WriteLine("***************************");
            //equality operators in linq
            List<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

            List<string> strList2 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

            bool isEqual = strList1.SequenceEqual(strList2);
            Console.WriteLine(isEqual);
            Console.WriteLine();
            Console.WriteLine("***************************");
            var innerJoinResult = studentList.Join(
                          standardList,   
                          student => student.StandardID,    
                          standard => standard.StandardID,  
                          (student, standard) => new  
                      {
                              StudentName = student.StudentName,
                              StandardName = standard.StandardName
                          });

            foreach (var obj in innerJoinResult)
            {

                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            }
            Console.WriteLine("********************************************");
            var groupJoin = standardList.GroupJoin(studentList,  
                                std => std.StandardID,  
                                s => s.StandardID,     
                                (std, studentsGroup) => new 
                                {
                                    Students = studentsGroup,
                                    StandarFulldName = std.StandardName
                                });

            foreach (var item in groupJoin)
            {
                Console.WriteLine(item.StandarFulldName);

                foreach (var stud in item.Students)
                    Console.WriteLine(stud.StudentName);
            }


        }
    }
}
