using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace join
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
        public static void Main(String[] args)
        {
            List<Department> d1 = new List<Department>
            {
                new Department{deptid=1,deptname="dev"},
                new Department{deptid=2,deptname="HR"},
                new Department{deptid=3,deptname="QA"}
            };
            List<Employee> e1 = new List<Employee>
            {
                new Employee{empid=101,empname="raju",salary=30000,deptid=1},
                new Employee{empid=102,empname="ravi",salary=45000,deptid=1},
                new Employee{empid=103,empname="naresh",salary=80000,deptid=2},
                new Employee{empid=104,empname="vyshnav",salary=70000}
            };
            
            var result = from emp in e1 join dept in d1 on emp.deptid equals dept.deptid 
                         select new 
                         { 
                             id = emp.empid, 
                             //name=emp.empname,
                             dname = dept.deptname 
                         };
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("***************************");
            var Result = from emp in e1

                          join dept in d1

                          on emp.deptid equals dept.deptid into empDept
                         

                          from ed in empDept.DefaultIfEmpty() 

                          select new
                          {

                              EmployeeName = emp.empname,

                              DepartmentName = ed == null ? "No Department" : ed.deptname

                          };
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("*********************");
            var Result1 = from dept in d1
                            join emp in e1
                            on dept.deptid equals emp.deptid into joinDeptEmp
                            from employee in joinDeptEmp.DefaultIfEmpty()
                            select new
                            {
                                employeeName = employee != null ? employee.empname : null,
                                deptname = dept.deptname
                            };
            foreach (var item in Result1)
            {
                Console.WriteLine(item.employeeName+"  "+item.deptname);
            }
            Console.WriteLine();
            Console.WriteLine("*******************************");
            var result2 = from emp in e1
                          join dept in d1 on emp.deptid equals dept.deptid into empdeptGroup
                          select new
                          {
                              department = empdeptGroup,
                              employee = emp.empname
                          };
            foreach (var item in result2)
            {
                Console.WriteLine((item.employee));
                foreach (var item1 in item.department)
                {
                    Console.WriteLine(item1.deptname);
                }
            }
            Console.ReadLine();
        }
    }
}
