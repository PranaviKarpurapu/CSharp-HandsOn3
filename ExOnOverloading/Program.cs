using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOnOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu\n");
            Console.WriteLine("1. Player Details of the Delivery");
            Console.WriteLine("2.Run Details of the Delivery");
            Console.WriteLine("Enter your Choice");
            int ch = int.Parse(Console.ReadLine());
            
            Delivery dl = new Delivery();
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Enter Bowler Name :");
                    string str1 = Console.ReadLine();
                    Console.WriteLine("Enter Batsman Name :");
                    string str2 = Console.ReadLine();
                    dl.DisplayDeliveryDetails(str1, str2);
                    break;

                case 2:
                    Console.WriteLine("Enter No.of Runs");
                    int r = int.Parse(Console.ReadLine());
                    dl.DisplayDeliveryDetails(r);
                    break;

                default :
                    Console.WriteLine("Invalid Option");
                    break;


            }
            Console.ReadLine();
        }
    }
}
