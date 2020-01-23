using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int high, low;
            Console.WriteLine("enter size of an array :");
            int size = int.Parse(Console.ReadLine());
            int[] large = new int[size];
            Console.WriteLine("enter array values :");
            for (int i=0;i<size;i++)
            {
                large[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" array values are :");
            foreach (int a in large)
            {
                Console.WriteLine(a);
            }
            for(int p=0;p<size;p++)
            { 
                for(int q=1;q<size;q++)              
                {
                    if (large[p] > large[q])
                        high = large[p];
                    if (large[p] < large[q])

                        low = large[p];
                }
            
                Console.WriteLine("\n"+high+"\n"+low);
            Console.ReadKey();

        }
       
    }
   
}
