using PrimeNumber.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number to check if it is prime number ");
            int inputNumber = int.Parse(Console.ReadLine());
            Prime.CheckAndPrintPrime(inputNumber);
            Console.ReadKey();
        }
    }
}
