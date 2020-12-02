using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Podaj liczbe: ");
                int number = GetNumber();

                var fizzBuzz = new FizzBuzz();

                Console.Write("Wynik to: ");

                fizzBuzz.CheckFizzBuzz(number);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static int GetNumber()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
                throw new Exception("To nie jest liczba");
            return input;
        }
    }
}
