using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    abstract class Marks
    {
        abstract public void getPercentage();

    }
    class A:Marks
    {
        int sub1;
        int sub2;
        int sub3;
        float avg;
        internal A(int s1,int s2,int s3)
        {
            this.sub1 = s1;
            this.sub2 = s2;
            this.sub3 = s3;
        }
        public override void getPercentage()
        {
            avg = ((sub1 + sub2 + sub3) / 3);
            Console.WriteLine("Average Percentage of A: {0}", avg);

        }
    }
    class B : Marks
    {
        int sub1;
        int sub2;
        int sub3;
        int sub4;
        float avg;

        internal B(int s1, int s2, int s3,int s4)
        {
            this.sub1 = s1;
            this.sub2 = s2;
            this.sub3 = s3;
            this.sub4 = s4;
        }
        public override void getPercentage()
        {
            avg = ((sub1 + sub2 + sub3+sub4) / 4);
            Console.WriteLine("Average Percentage of B: {0}", avg);

        }
    }


    class A2Abstract2
    {
        static void Main()
        {
            int sub1;
            int sub2;
            int sub3;
            int sub4;
            
            
            string entry;
            Console.WriteLine("Enter the student A or B");
            entry = Console.ReadLine();
            if(entry=="A" || entry=="a")
            {
                Console.WriteLine("Enter the SUB 1 marks");
                sub1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the SUB 2 marks");
                sub2= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the SUB 3 marks");
                sub3 = Convert.ToInt32(Console.ReadLine());

                A a = new A(sub1, sub2, sub3);
                a.getPercentage();
            }
            else
            {
                Console.WriteLine("Enter the SUB 1 marks");
                sub1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the SUB 2 marks");
                sub2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the SUB 3 marks");
                sub3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the SUB 4 marks");
                sub4 = Convert.ToInt32(Console.ReadLine());
                B b = new B(sub1, sub2, sub3,sub4);
                b.getPercentage();

            }
        }
    }
}
