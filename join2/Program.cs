using System;
using System.Collections.Generic;
using System.Linq;
namespace join2
{
    class Company
    {
        public String companyName { get; set; }
        public int companyid { get; set; }
    }
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
        public int companyid { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Company> cp = new List<Company>
            {
                new Company{companyName="TCS",companyid=1},
                new Company {companyName="capgemini",companyid=2},
                new Company{companyName="cognine",companyid=3}
            };
            List<Department> d1 = new List<Department>
            {
                new Department{deptid=1,deptname="dev",companyid=1,},
                new Department{deptid=2,deptname="HR",companyid=2},
                new Department{deptid=3,deptname="QA",companyid=3}
            };
            List<Employee> e1 = new List<Employee>
            {
                new Employee{empid=101,empname="raju",salary=30000,deptid=1},
                new Employee{empid=102,empname="ravi",salary=45000,deptid=2},
                new Employee{empid=103,empname="naresh",salary=80000,deptid=3},
                new Employee{empid=104,empname="vyshnav",salary=70000}
            };
            var result3 = e1.First(i => i.empid == 100);
            Console.WriteLine(result3);
            Console.WriteLine();
            var Result = from company in cp
                         join department in d1 on company.companyid equals department.companyid
                         join emp in e1 on department.deptid equals emp.deptid
                         select new { companyname = company.companyName, dname = department.deptname, ename=emp.empname };
            foreach (var item in Result)
            {
                Console.WriteLine(item.companyname+"  "+item.ename+"  "+item.dname);
            }
            Console.WriteLine("******************************");
            var result = (from department in d1
                         from employee in e1
                         orderby department.deptid
                         select new { department.deptname, employee.empname });
            foreach (var item in result)
            {
                Console.WriteLine(item.deptname+"  "+item.empname);
            }
            Console.WriteLine();
            Console.WriteLine("*******************");
            //var result1 = from company in cp
            //              join department in d1 on company.companyid equals department.companyid option(merge join)
        }
    } 
}
