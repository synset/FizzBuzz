using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");

            string number = Console.ReadLine();
            Int32.TryParse(number, out int nr);

            for (int i = 0; i < nr; i++)
            {
                string result = "";
                if (i % 3 == 0) result = "Fizz";          
                if (i % 4 == 0) result = result + "Buzz";
                if (result.Length == 0) result = i.ToString();

                Console.WriteLine(result);
            }
        }
    }
}