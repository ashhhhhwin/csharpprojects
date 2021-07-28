using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Vehicle
    {
        protected string regNumber { get; set; }
        protected string speed { get; set; }
        protected string color { get; set; }
        protected string ownerName { get; set; }
        protected Vehicle(string regNumber, string speed, string color ,string ownerName)
        {
            this.regNumber = regNumber;
            this.speed = speed;
            this.color = color;
            this.ownerName = ownerName;
        }
        internal virtual void showData()
        {
            Console.WriteLine("This is the Vehicle Class");
        }
    }
    class Bus:Vehicle
    {
        int routeNumber { get; set; } 
        internal Bus(string regNumber, string speed, string color, string ownerName,int route):base(regNumber,speed,color,ownerName)
        {
            this.routeNumber = route;
        }
        internal override void showData()
        {
            base.showData();
            Console.WriteLine("Bus Route Number: {0} | RegNumber: {1} | Owner Name: {2} | Speed: {3}" +
                "| Colour: {4} | ", routeNumber, regNumber, ownerName, speed, color);
        }
    }
    class Car:Vehicle
    {
        string ManufacturerName { get; set; }
        internal Car(string regNumber, string speed, string color, string ownerName, string MName) : base(regNumber, speed, color, ownerName)
        {
            this.ManufacturerName = MName;
        }
        internal override void showData()
        {
            base.showData();
            Console.WriteLine("Car Manufacturer Name: {0} | RegNumber: {1} | Owner Name: {2} | Speed: {3}" +
                "| Colour: {4} | ", ManufacturerName, regNumber, ownerName, speed, color);
        }
    }

    class A2Inheritance
    {
        static void Main()
        {
            string regNumber;
            string speed;
            string color;
            string ownerName;
            int route;
            string entry;
            string company;
            Console.WriteLine("Enter which vehicle(for Car press 'C' or For Bus press 'B'");
            entry = Console.ReadLine();
            if(entry=="B")
            {
                Console.WriteLine("Enter the Bus Registration Number: ");
                regNumber = Console.ReadLine();
                Console.WriteLine("Enter the Bus Owner Name: ");
                ownerName = Console.ReadLine();
                Console.WriteLine("Enter the Bus Max Speed: ");
                speed = Console.ReadLine();
                Console.WriteLine("Enter the Bus colour: ");
                color = Console.ReadLine();
                Console.WriteLine("Enter the route number:  ");
                route = Convert.ToInt32(Console.ReadLine());
                Bus bus = new Bus(regNumber, speed, color, ownerName, route);
                bus.showData();
            }
            else
            {
                Console.WriteLine("Enter the Car Registration Number: ");
                regNumber = Console.ReadLine();
                Console.WriteLine("Enter the Car Owner Name: ");
                ownerName = Console.ReadLine();
                Console.WriteLine("Enter the Car Max Speed: ");
                speed = Console.ReadLine();
                Console.WriteLine("Enter the Car colour: ");
                color = Console.ReadLine();
                Console.WriteLine("Enter the Company name:  ");
                company = Console.ReadLine();
                Car car = new Car(regNumber, speed, color, ownerName, company);
                car.showData();

            }
            

        }
    }
}
