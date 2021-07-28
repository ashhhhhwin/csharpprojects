using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    interface INormalCal
    {
        int Add(int x, int y);
        int Sub(int x, int y);
    }
    interface IsciCal
    {
        int Add(int x, int y);
        int Mul(int x, int y);
    }
    class Calculator:INormalCal,IsciCal
    {
        int INormalCal.Add(int x, int y)
        {
            return x + y;
        }
        public int Mul(int x,int y)
        {
            return (x * y);
        }
        public int Sub(int x, int y)
        {
            return (x - y);
        }
        public int Add(int x, int y)
        {
            return (x + y);
        }
    }


    class InterfaceEg
    {
        static void Main()
        {
            INormalCal calculator = new Calculator();
            Console.WriteLine("The addition reuslt is {0}", calculator.Add(5, 4));

            Console.WriteLine("The sub reuslt is {0}", calculator.Sub(5, 4));
            IsciCal calculator1 = new Calculator();

            Console.WriteLine("The add reuslt is {0}", calculator1.Add(10,10));

            Console.WriteLine("The mul reuslt is {0}", calculator1.Mul(10,10));
        }
    }
}
