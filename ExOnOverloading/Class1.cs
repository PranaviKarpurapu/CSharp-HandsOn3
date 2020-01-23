using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOnOverloading
{
    class Delivery
    {
       public void DisplayDeliveryDetails(string bowler,string batsman)
        {
            Console.WriteLine("Bowler :" + bowler);
            Console.WriteLine("Batsman :" + batsman);
        }

       public void DisplayDeliveryDetails(long runs)
        {
            if(runs==6)
            Console.WriteLine("It is a Six...!!!");
            else if(runs==4)
            Console.WriteLine("It is a Four...!!!");
            else
                Console.WriteLine("Runs :" + runs);

        }
    }
}
