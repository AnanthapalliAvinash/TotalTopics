using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Basics
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {

            int[] arr = { 19, 3, 47, 89, 56, 8, 43, 34, 59, 30, 28 };
            int[] arr1 = { 15, 23, 67, 3, 28, 56, 8 };
            List<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
        new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
    };
            var selectResult = from s in studentList
                                select s.StudentName;
            foreach (var item in selectResult)
            {
                Console.WriteLine(item);
            }
           /* var groupedResult1 = studentList.Select(x => x.StudentName);
            foreach (var item in groupedResult1)
            {
                Console.WriteLine(item);
            }*/
            var groupedResult = from s in studentList
                                group s by s.Age;
            //iterate each group        
            foreach (var ageGroup in groupedResult)
            {
                //Console.WriteLine(ageGroup);
                Console.WriteLine("Age Group: {0}", ageGroup.Key);  

                foreach (Student s in ageGroup) 
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
            Console.WriteLine("***********************************");
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 40)
                    count += 1;
            }
            int[] brr = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 40)
                {
                    brr[index] = arr[i];
                    index += 1;
                }
            }
            Array.Sort(brr);
            Array.Reverse(brr);
            foreach (var i in brr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            var n = from i in arr where i > 40 select i;
            foreach (var k in n)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();
            var b = from i in arr where i > 40 orderby i descending select i;
            foreach (var k in b)
                Console.WriteLine(k);
            Console.WriteLine();
            var result = arr.Concat(arr1);
            //var result = arr.Union(arr1);
            foreach (var j in result)
            {
                Console.Write(j+"  ");
            }
            Console.WriteLine();
            Console.WriteLine("******************");
            var h = arr.Where(obj => obj > 40);
            
            foreach (var k in h)
                Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}
