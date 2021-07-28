using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    abstract class RBI
    {
        internal string rule = "Customer should have aadhar";
        
        //RBI Abstract methos
        abstract public int HomeLoan();
        abstract public int EduLoan();


    }
    abstract class SBI:RBI
    {
        abstract public void SBICustomer();
        public override int HomeLoan()
        {
            return 8;
        }
        public override int EduLoan()
        {
            return 5;
        }
    }

    class SBIBranch:SBI
    {
        public override void SBICustomer()
        {
            Console.WriteLine("It has 1 lakh customer");

        }
    }
    class AbstractEg
    {
        static void Main()
        {
            int a, b;
            string c;
            SBIBranch sBIBranch = new SBIBranch();
            sBIBranch.SBICustomer();
            a=sBIBranch.HomeLoan();
            b=sBIBranch.EduLoan();
            Console.WriteLine("HomeLoan Percent: {0} | EduLoan percent: {1}", a, b);

            c=sBIBranch.rule;
            Console.WriteLine("Rule is " + c);
        }
    }
}
