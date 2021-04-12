using System;

namespace Lab_4._3._0___Prime_Numbers
{
    public class PrimeNumber
    {
        public int GetPrime(int userSel)
        {
            int foundPrime = 0;
            int number = 0;
            while (foundPrime != userSel)
            {
                int divisors = 0;
                number++;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        divisors++;
                    }
                }
                if (divisors == 2)
                {
                    foundPrime++;
                }
            }
            return number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Let's locate some primes!");
                PrimeNumber myPrime = new PrimeNumber();

                Console.Write("\nWhich prime number are you looking for? ");
                int entry = Convert.ToInt32(Console.ReadLine());
                int result = myPrime.GetPrime(entry);

                Console.WriteLine(result);

                Console.Write("\nDo you want to find another prime number? (y/n): ");
                string doneYN = Console.ReadLine();
                while (doneYN != "y" && doneYN != "yes" && doneYN != "n" && doneYN != "no")
                {
                    Console.Write("\nInvalid response || Type 'Y' or 'N':  ");
                    doneYN = Console.ReadLine();
                }
                if (doneYN == "n" || doneYN == "no")
                {
                    done = true;
                }

            }
            
        }
    }
}
