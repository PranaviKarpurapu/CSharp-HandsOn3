using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnVariablesWithDatatypes
{
    class Program
    {

        static void Main(string[] args)
        {
            int i=10;
            /*
            Console.WriteLine(i);
           // Console.WriteLine(Program.sal);
           // Console.ReadLine(name);*/
            int[] a = new int[4] { 10, 11, 12, 13 };
            Program prg = 10;

            prg = 'a';
            prg = 12.3;
            int k = 10;
            string nam = "Pranavi";
            Console.WriteLine("Name :{0} Age :{1}",nam,k);
            Console.ReadKey();
        }
    }
}
