using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnInterface   
    
{
    //interface 1
    interface DemoInterface
    {
       void GetInterest();
    }
    //interface 2
    interface GoldLoan :DemoInterface   //interface supports inheritance
        
    {
        void GetGoldLoan();
    }

    //interface 3
    interface Dmat
    {
        void GetDmat();
    }

    abstract class Bank
    {
        protected string bname;
        protected string location;

        public Bank(string bname, string location)
        {
            this.bname = bname;
            this.location = location;
        }

        public abstract void Display();

    }


    class Sbi:Bank,DemoInterface,GoldLoan  //inheriting class, implementing both interfaces and their methods
    {
        string bManager;

        public Sbi(string bname, string location,string bmgr):base(bname,location)
        {
            this.bManager = bmgr;
        }
        public override void Display()
        {
            Console.WriteLine("Bank Name : " + this.bname + "\nLocation  : " + this.location+"\nBank Manager :"+this.bManager);
        }

        public void GetInterest()
        {
            Console.WriteLine("SBI Loan Interst is : 12%");
        }

        public void GetGoldLoan()
        {
            Console.WriteLine("SBI Gold Loan Interst is : 42%");
        }
    }

    class Icici : Bank, DemoInterface,Dmat   //inheriting class, implementing both interfaces and their methods
    {
        string bHead;

        public Icici(string bname, string location, string bhead) : base(bname, location)
        {
            this.bHead = bhead;
        }
        public override void Display()
        {
            Console.WriteLine("\n\nBank Name : " + this.bname + "\nLocation  : " + this.location + "\nBank Head :" + this.bHead);
        }

        public void GetInterest()
        {
            Console.WriteLine("ICICI Loan Interst is : 18%");
        }

        public void GetDmat()
        {
            Console.WriteLine("ICICI can give Dmat accounts");
        }
    }
}
