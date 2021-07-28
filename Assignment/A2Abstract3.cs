using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    abstract class Student
    {
        protected int sID { get; set; }
        protected string sName { get; set; }
        protected int sGrade { get; set; }
        abstract public Boolean  isPassed(int grade);
    }

    class Undergraduate:Student
    {
        
        
        public override bool isPassed(int grade)
        {
            if(grade>70)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
    class graduate : Student
    {

        
        public override bool isPassed(int grade)
        {
            if (grade > 80)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
    class A2Abstract3
    {
        static void Main()
        {
            string entry;
            int grade;
            Boolean pass;
            Console.WriteLine("Enter if the student is Undergraduate or Graduate");
            entry = Console.ReadLine();
            if(entry=="Undergraduate")
            {
                Console.WriteLine("Enter the grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                Undergraduate undergraduate = new Undergraduate();
                pass=undergraduate.isPassed(grade);
                Console.WriteLine(pass);
            }
            else
            {
                Console.WriteLine("Enter the grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                graduate graduate = new graduate();
                pass = graduate.isPassed(grade);
                Console.WriteLine(pass);
            }
        }
    }
}
