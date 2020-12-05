using System;

namespace _1_report_repair
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetSum = 2020;
            Console.WriteLine($"Hello!  I will find the 2 numbers from this list of 200 that sum to {targetSum}\n");

            string[] input = System.IO.File.ReadAllLines(@"C:\Users\jenev\source\repos\Practice\advent-of-code\1-report-repair\input.txt");
            int inputLength = input.Length;

            bool continueSearching = true;
            int product = 0;
            int inputA = 0;
            int inputB = 0;

            for (int a = 0; (a < inputLength - 1) && continueSearching; a++)
            {
                inputA = Convert.ToInt32(input[a]);

                for(int b = a + 1; (b < inputLength) && continueSearching; b++)
                {
                    inputB = Convert.ToInt32(input[b]);

                    if(inputA + inputB == targetSum)
                    {
                        continueSearching = false;
                        product = inputA * inputB;
                    }
                }
            }

            Console.WriteLine($"first number: {inputA}, second number: {inputB}, product: {product}");
        }
    }
}
