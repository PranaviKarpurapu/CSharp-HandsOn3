using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOnOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st;
            Console.WriteLine("Enter Student Id :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name :");
            string name = Console.ReadLine();
            double transfee = 10000;
            double examfee = 800;
            double hosfee = 25000;
            Console.WriteLine("\nMenu :\n1.DayScholar\n2.Hosteller\nEnter your choice");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    st = new DayScholar(id, name, examfee, transfee);
                    st.DisplayDetails();
                    st.PayFee();
                    break;

                case 2:
                    st = new Hosteller(id, name, examfee, hosfee);
                    st.DisplayDetails();
                    st.PayFee();
                    break;

                default:
                    break;
            }
            Console.ReadKey();
            }
    }
}
