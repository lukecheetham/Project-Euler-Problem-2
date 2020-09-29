using System;

namespace EulerProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibFirst = 0;
            int fibNext = 1;
            int result = 0;
            int sum = 0;

            while (result < 4000000)
            {
                result = fibFirst + fibNext;
                fibFirst = fibNext;
                fibNext = result;

                if ((result % 2) == 0)
                {
                    sum += result;
                    Console.WriteLine($"{result}, ");
                }
            }

            Console.WriteLine($"Total sum of all the even numbers in the Fibonacci sequence is: {sum}");
        }
    }
}
