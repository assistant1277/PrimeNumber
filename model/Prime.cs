using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber.model
{
    public class Prime
    {
        public static void CheckAndPrintPrime(int number)
        {
            if (number <= 1)
            {
                Console.WriteLine($"{number} not a prime number");
                return;
            }

            bool isPrime = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            string resultMessage = isPrime ? $"{number} is a prime number " : $"{number} is not a prime number";
            Console.WriteLine(resultMessage);
        }
    }
}
