using PrimeFactors;
using System;

namespace Primefactors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Prime Factors Program");
           

            Factors prime=new Factors();
            prime.PFactors();
        }
    }
}