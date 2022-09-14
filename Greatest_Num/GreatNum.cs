using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Num
{
    internal class GreatNum
    {
        static void Main(string[] args)
        { 

        
            int n1, n2,n3;

        Console.WriteLine("Enter the value of n1:");
            n1= int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of n2:");
            n2= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of n3:");
            n3 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine($"Largest Number is: {n1}");
                }
                else
                {
                    Console.WriteLine($"Largest Number is: {n3}");

                }

            }

            else
            {
                if(n2> n3)
                {
                    Console.WriteLine($"Largest Number is: {n2}");
                }
                else
                {
                    Console.WriteLine($"Largest Number is: {n3}");
                }
            }
            





        }
    }
}
