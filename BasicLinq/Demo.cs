using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Linq_Basics
{
    class Employee 
    {
        public int empid { get; set; }
        public string empname { get; set; }
        public int salary { get; set; }
        public int deptid { get; set; }
    }
    class Department
    {
        public int deptid { get; set; }
        public string deptname { get; set; }
    }
   
    class Demo
    {
        public static void main()
        {
            List<Employee> e1 = new List<Employee>
            {
                new Employee{empid=101,empname="raju",salary=30000,deptid=1},
                new Employee{empid=102,empname="ravi",salary=45000,deptid=1},
                new Employee{empid=103,empname="naresh",salary=80000,deptid=2}
            };
            List<Department> d1 = new List<Department>
            {
                new Department{deptid=1,deptname="dev"},
                new Department{deptid=2,deptname="HR"},
                new Department{deptid=3,deptname="QA"}
            };
            var result = from e in e1 join d in d1 on e.deptid equals d.deptid into dGroup select new { name = e.empname, dname = dGroup };
        }
    }
}
