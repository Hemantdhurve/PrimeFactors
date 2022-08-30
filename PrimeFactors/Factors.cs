using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    public class Factors
    {
        public void PFactors()
        {
            Console.WriteLine("\tEnter the Number which User want to get Prime Factors:");
            Console.WriteLine("Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i < number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i);

                    number = number / i;
                }
            }

            if(number > 2)
            {
                Console.WriteLine(number);
            }
        }
    }
}
