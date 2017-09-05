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

        public FizzBuzz()
        {
            this.message = new List<String>();
            int iterations = 0;
            String iterationsString = "-1";
            while(!Int32.TryParse(iterationsString, out iterations) || !(iterations > 0))
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
                if (i % 3 == 0)
                {
                    ExtendMessage("Fizz");
                }

                if (i % 13 == 0)
                {
                    ExtendMessage("Fezz");
                }

                if (i % 5 == 0)
                {
                    ExtendMessage("Buzz");
                }

                if (i % 7 == 0)
                {
                    ExtendMessage("Bang");
                }

                if (i % 11 == 0)
                {
                    this.message = new List<string>();

                    if (i % 13 == 0)
                    {
                        ExtendMessage("Fezz");
                    }

                    ExtendMessage("Bong");
                }
                
                if (i % 17 == 0)
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
            FizzBuzz test = new FizzBuzz();
            test.Run();
            Console.ReadKey();
        }
    }
    
}
