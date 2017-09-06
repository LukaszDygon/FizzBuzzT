using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        List<String> message;
        int iterations;
        int[] allowed;

        public FizzBuzz(int[] allowed)
        {
            this.message = new List<String>();
            int iterations = 0;
            String iterationsString = "-1";
            this.allowed = allowed;

            while (!Int32.TryParse(iterationsString, out iterations) || !(iterations > 0))
            {
                Console.WriteLine("Number of iterations (must be greater than 0):");
                iterationsString = Console.ReadLine();
            }
            this.iterations = iterations;
        }

        private void ExtendMessage(String message)
        {
            this.message.Add(message);
        }

        private void PrintMessage(int iteration)
        {
            if (this.message.Any())
            {
                String messageString = String.Join("", this.message.ToArray());
                Console.WriteLine(messageString);
            }
            else
            {
                Console.WriteLine(iteration.ToString());
            }
        }

        public void Run()
        {
            for (int i = 1; i <= this.iterations; i++)
            {
                if (allowed.Contains(3) && i % 3 == 0)
                {
                    ExtendMessage("Fizz");
                }

                if (allowed.Contains(13) && i % 13 == 0)
                {
                    ExtendMessage("Fezz");
                }

                if (allowed.Contains(5) && i % 5 == 0)
                {
                    ExtendMessage("Buzz");
                }

                if (allowed.Contains(7) && i % 7 == 0)
                {
                    ExtendMessage("Bang");
                }

                if (allowed.Contains(11) && i % 11 == 0)
                {
                    this.message.RemoveAll(s => s != "Fezz");

                    ExtendMessage("Bong");
                }
                
                if (allowed.Contains(17) && i % 17 == 0)
                {
                    this.message.Reverse();
                }

                PrintMessage(i);
                this.message = new List<string>();

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] allowed = Array.ConvertAll(args, s => int.Parse(s));
            FizzBuzz fizzbuzz = new FizzBuzz(allowed);
            fizzbuzz.Run();
            Console.ReadKey();
        }
    }
    
}
