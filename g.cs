using System;

namespace GoldenRule
{
    class Program
    {
        static double Calculate(int to_val)
        {
            const int NUMBER_ONE = 1;
            int i = NUMBER_ONE;
            int j = NUMBER_ONE;
            int tmp = 0;
            for (int val = 0; val < to_val; val++)
            {
                tmp = i + j;
                i = j;
                j = tmp;
            }
            return (double)j / i;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(24).ToString());
        }
    }
}
