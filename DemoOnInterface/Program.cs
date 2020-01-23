using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Sbi sb = new Sbi("SBI","Banglore","Arun");
            Icici ic = new Icici("ICICI", "Hyderabad", "Jaya");
            
            sb.Display();
            sb.GetInterest();
            sb.GetGoldLoan();

            ic.Display();
            ic.GetInterest();
            ic.GetDmat();

            Console.ReadLine();
        }
    }
}
