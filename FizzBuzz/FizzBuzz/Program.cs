using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            this.iterations = 100;
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
            for (int i = 0; i < this.iterations; i++)
            {
                if (i % 3 == 0)
                {
                    ExtendMessage("Fizz");
                }

                if (i % 5 == 0)
                {
                    ExtendMessage("Buzz");
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
