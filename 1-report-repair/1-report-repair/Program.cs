using System;

namespace _1_report_repair
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] input = System.IO.File.ReadAllLines(@"C:\Users\jenev\source\repos\Practice\advent-of-code\1-report-repair\input.txt");
            int inputLength = input.Length;
            Console.WriteLine($"length: {inputLength}");

            //foreach(string item in input)
            //{
            //    Console.WriteLine(item);
            //}

            //bool success = false;
            int solution = 0;
            int inputA = 0;
            int inputB = 0;

            for (int a = 0; a < inputLength - 1; a++)
            {
                inputA = Convert.ToInt32(input[a]);

                for(int b = a + 1; b < inputLength; b++)
                {
                    inputB = Convert.ToInt32(input[b]);

                    if(inputA + inputB == 2020)
                    {
                        //success = true;
                        solution = inputA * inputB;
                    }
                }
            }

            Console.WriteLine($"a: {inputA}, b: {inputB}, product: {solution}");
        }
    }
}
