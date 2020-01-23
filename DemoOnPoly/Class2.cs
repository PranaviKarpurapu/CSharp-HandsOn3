using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnPoly
{
    abstract class A
    {
        //public virtual void Display()
        //{
        //    Console.WriteLine("Displaying A class details");
        //}

        public abstract void Display();
        
    }

    class B:A
    {
        public override void  Display()
        {
            Console.WriteLine("Displaying B class details");
        }
    }



    class C : A
    {
        public override void  Display()
        {
            Console.WriteLine("Displaying C class details");
        }
    }
}