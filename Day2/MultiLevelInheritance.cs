using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    enum Feedback
    {
        Poor=1,Fair,Good,Excellent=5
    };


    //Base class or parent class
    class Department
    {
        //Protected is used within the class and derived class only
        protected int Did { get; set; }
        protected string Dname { get; set; }
        protected string City { get; set;}
        internal Department(int Did,string Dname,string City)
        {
            Console.WriteLine("Department Constructor");
            this.Did = Did;
            this.Dname = Dname;
            this.City = City;

        }
        protected internal void DisplayDepartmentinfo()
        {
            Console.WriteLine("Department ID: {0} | Department Name: {1} | Department City: {2}", Did, Dname, City);
        }
        ~Department()
        {
            Console.WriteLine("Department Destructor");
        }
    }
    //Single Inheritance
    //Derived class or child class
    class Employee:Department
    {
        internal static string companyName = "LTI";
        internal int Eid { get; set; }
        internal string Ename { get; set; }
        internal string City = "Pune";
        internal Employee(int Eid,string Name,int Did, string Dname,string city):base(Did, Dname,city)
        {
            Console.WriteLine("Employee Constructor");
            this.Eid = Eid;
            this.Ename = Name;
            
        }
        internal void DisplayEmployeeDetails()
        {
            DisplayDepartmentinfo();

            Console.WriteLine("Employee ID: {0} | Employee Name: {1} | Employee Dept ID: {2} | Employee City: {3}", Eid, Ename, base.Did, City);
        }
        ~Employee()
        {
            Console.WriteLine("Employee Destructor");
        }
    }
    class TempEmployee:Employee
    {
        int workingHours { get; set; }
        int Salary { get; set; }
        internal TempEmployee(int workingHours,int Salary, int Eid, string Name, int Did, string Dname, string city):
            base(Eid,Name, Did, Dname, city)
        {
            this.workingHours = workingHours;
            this.Salary = Salary;
        }
        internal int YearlySalary()
        {
            int MSalary = (Salary * 12);
            return MSalary;
        }
        internal void DisplayTempEmployeeDetails()
        {
            DisplayDepartmentinfo();
            
            Console.WriteLine("Employee WHours: {0} | Employee Salary: {1} | Employee ID: {2} | Employee Name: {3} | " +
                "Employee Dept ID: {4} | Employee City: {5}", workingHours, Salary, Eid, Ename, Did, City);
        }
        //Destructor to remove unused memory, btw Csharp mai kudh hota hai
        ~TempEmployee()
        {
            Console.WriteLine("TempEmployee Destuctor");
        }
    }


    class MultiLevelInheritance
    {
        static void Main()
        {
            Department department = new Department(12,"HR","Chennai");
            
            Employee employee = new Employee(11, "Ashwin",12,"HR","Mumbai");
            employee.DisplayEmployeeDetails();
            TempEmployee tempEmployee = new TempEmployee(64, 1000, 102, "Äniket", 12, "HR", "Pune");
            tempEmployee.DisplayTempEmployeeDetails();
        }
    }
}
