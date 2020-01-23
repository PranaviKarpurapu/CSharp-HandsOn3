using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnPoly
{
    class Program
    {
        static void Main(string[] args)
        {
            /* SHAPE PROGRAM
            
            Shape pic = new Shape();
            pic.Draw();
            pic.Draw(6);
            pic.Draw(7,8);
            pic.Draw(1,2,3);
            pic.Draw(1,2,3,"picture");
            Console.ReadKey();
        }
    }

    */

/* Model 1 : Since B,C inherits A but invokes their own methods(Overloading)

A a = new A();
a.Display();
B b = new B();
b.Display();
C c = new C();
c.Display();

*/

/* Model 2 : Since B,C inherits A they invokes only A's  methods
A a = new A();
a.Display();
a = new B();
a.Display();
a= new C();
a.Display();
*/


/* Model 3 : Since B,C inherits A but they need to invoke their own methods then virtual is used (overriding)
A a = new A();
a.Display();
a = new B();
a.Display();
a= new C();
a.Display();
*/

/* Model 4 : Since B,C inherits A which is created as Abstract and also a method of abstract, no need to create memory for A,but by using A obj we can call B,C methods

A a; 

a = new B();
a.Display();
a = new C();
a.Display();


    */

Console.ReadKey();

}
}
}
