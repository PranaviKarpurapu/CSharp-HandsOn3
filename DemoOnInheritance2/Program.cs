using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnInheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle v = new Vehicle();
            Car c= new Car("Red",50,"Nano");
            Bus b = new Bus();

            //v.Start();
            //v.Stop();
            Console.WriteLine("\n\n");
            c.Start();
            c.Drive();
            c.fill_fuel();
            c.Stop();
            
            Console.WriteLine("\n\n");


            b.Start();
            b.Run();
            c.fill_fuel();
            b.Stop();
                        
            
            Console.ReadKey();
        }
    }
}
