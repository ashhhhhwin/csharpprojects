using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    abstract class NCar
    {
        protected string regno;
        internal NCar(string regno)
        {
            this.regno = regno;
        }
        void openTank()
        {
            Console.WriteLine("--------");
        }
        abstract public void steering(int direction, int angle);
        abstract public void breaking(int force);
    }

    class Tata:NCar
    {
        int direction { get; set; }
        int angle { get; set; }
        int force { get; set; }
        internal Tata(int direction,int angle,int force,string regno):base(regno)
        {
            this.angle = angle;
            this.direction = direction;
            this.force = force;
        }
        public override void steering(int direction,int angle)
        {
            Console.WriteLine("Maximum Steering Direction: {0} | Maximum Steering Angle: {1} ", direction, angle);
        }
        public override void breaking(int force)
        {
            Console.WriteLine("Force of Vehicle: {0}", force);
        }
    }
    class Mahindra : NCar
    {
        int direction { get; set; }
        int angle { get; set; }
        int force { get; set; }
        
        internal Mahindra(int direction, int angle, int force, string regno) : base(regno)
        {
            this.angle = angle;
            this.direction = direction;
            this.force = force;
        }
        public override void steering(int direction, int angle)
        {
            Console.WriteLine("Maximum Steering Direction: {0} | Maximum Steering Angle: {1} ", direction, angle);
        }
        public override void breaking(int force)
        {
            Console.WriteLine("Force of Vehicle: {0}", force);
        }
    }
    class A2Abstract
    {
        static void Main()
        {
            String entry;
            int direction;
            int angle;
            int force;
            string regno;
            Console.WriteLine("Write your Vehicle brand: ");
            entry = Console.ReadLine();
            
            if(entry=="Tata")
            {
                Console.WriteLine("WELCOME TO TATA");
                Console.WriteLine("Registration Number: ");
                regno = (Console.ReadLine());
                Console.WriteLine("Maximum Steering Direction:");
                direction = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Maximum Steering Angle:");
                angle = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Maximum Force");
                force = Convert.ToInt32(Console.ReadLine());
                Tata tata = new Tata(direction, angle,force,regno);
                tata.steering(direction, angle);
                tata.breaking(force);




            }
            else
            {

                Console.WriteLine("WELCOME TO MAHINDRA");
                Console.WriteLine("Registration Number: ");
                regno = (Console.ReadLine());
                Console.WriteLine("Maximum Steering Direction:");
                direction = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Maximum Steering Angle:");
                angle = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Maximum Force");
                force = Convert.ToInt32(Console.ReadLine());
                Mahindra mahindra = new Mahindra(direction, angle, force, regno);
                mahindra.steering(direction, angle);
                mahindra.breaking(force);
            }
        }
    }
}
