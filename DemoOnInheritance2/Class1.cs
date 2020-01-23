using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnInheritance2
{
     abstract class Vehicle    // to stop inheritance we use "sealed" i.e., sealed class Vehicle .
    {
        protected string color;

        public Vehicle()  //invoked automatically by child classes
        {
            this.color = "White";
            Console.WriteLine("\nVehicle Constructor");
        }

        

        public Vehicle(string clr)    //invoked by using base keyword by child classes and providing value
        {
            this.color = clr;
            Console.WriteLine("\nVehicle Paremeterized Constructor");
        }


        public abstract void fill_fuel();         //child should compulsorily override

        public virtual void Start()                 //child may/may not override 
        {
            Console.WriteLine("Vehicle Started");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle Stopped");
        }

    }

    class Bus:Vehicle
    {
        int seating;
        int speed;

        public Bus():base("Green")  //(clr) value is provided by user
        {
            this.seating = 45;
            this.speed = 70;
            Console.WriteLine("Bus Constructor");
            Console.WriteLine(this.color+" Bus is running at speed : "+this.speed+"kmph with "+this.seating+" seats\n");
        }


        public override void fill_fuel()
        {
            Console.WriteLine("Filled in Bus ");
        }

        public override void Start()
        {
            Console.WriteLine("Bus Started");
        }
        public void Run()
        {
            Console.WriteLine("Bus is running");
        }
    }

    class Car:Vehicle
    {
        int speed;
        string type;

        public Car()
        {
            this.speed = 90;
            this.type = "Santro";
            Console.WriteLine("Car Construcor");
            Console.WriteLine(this.color+" "+this.type+" car is running at speed : "+this.speed+"kmph");
        }

        public Car(string clr, int spd, string type):base(clr)     //(clr) value is taken at runtime
        {
            this.speed = spd;
            this.type = type;
            Console.WriteLine("Car Parameterized Construcor");
            Console.WriteLine(this.color + " " + this.type + " car is running at speed : " + this.speed + "kmph");
        }


        public override void fill_fuel()
        {
            Console.WriteLine("Filled in Car ");
        }

        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }
}
