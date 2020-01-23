using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOnOverride
{
    abstract class Student
    {
       public int stuId;
        public string stuName;
        public double examFee;

        public Student(int stuId, string stuName, double examFee)
        {
            this.stuId= stuId;
            this.stuName = stuName;
            this.examFee = examFee;

        }

        public abstract void DisplayDetails();
       
    public abstract void PayFee();
       
    }
    class DayScholar:Student
    {
        double transportFee;

        public DayScholar(int stuId, string stuName, double examFee,double transportFee): base(stuId,stuName,examFee)
        {
            this.transportFee = transportFee;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("\nStudent Id : " + stuId + "\nStudent Name :" + stuName);
        }

        public override void PayFee()
       {
            Console.WriteLine("Transport Fee : " + transportFee);
            Console.WriteLine("Exam Fee : " +examFee);
            Console.WriteLine("Fee need to be paid : " + (transportFee+examFee));

        }
    }


    class Hosteller : Student
    {
        double hostelFee;

        public Hosteller(int stuId, string stuName, double examFee, double hostelFee) : base(stuId, stuName, examFee)
        {
            this.hostelFee = hostelFee;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("\nStudent Id : " + stuId + "\nStudent Name :" + stuName);
        }

        public override void PayFee()
        {
            Console.WriteLine("Hostel Fee : " + hostelFee);
            Console.WriteLine("Exam Fee : " + examFee);
            Console.WriteLine("Fee need to be paid : " + (hostelFee + examFee));

        }
    }
}
