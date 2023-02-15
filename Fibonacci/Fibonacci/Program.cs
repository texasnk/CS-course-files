using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number for the fibonacci sequence: ");
            long fibo = long.Parse(Console.ReadLine()), a=0, b=1, c=0;
   
            for(int i=0;i<fibo; i++)
            {
                if (i < fibo - 1)
                {
                    Console.Write(a + ", ");
                }
                else
                {
                    Console.Write(a);
                }
                c = a + b;
                a = b;
                b = c;


            }

    

            Console.ReadKey();
        }
    }
}
