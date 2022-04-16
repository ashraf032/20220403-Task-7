using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int eded = 123321;
            int temp = eded;
            int reverse = 0;
            int counter = 0;
            while (temp > 0)
            {
                counter++;
                reverse += temp * 10 + temp % 10;
                temp /= 10;
            }
            Console.WriteLine(eded);
            Console.WriteLine(reverse);

            if (eded==temp)
            {
                temp = (int)(Math.Pow(10, counter) + eded);
                eded = temp * 10 + 1;
            }
            Console.WriteLine(eded);
        }

    }
}
