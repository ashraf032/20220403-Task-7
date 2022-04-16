using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = 0;
            int number = 0;

            for (int i = 2; i <=1000 ; i++)
            {
                if (i%2==0)
                {
                    int a = i;
                    while (a!=0)
                    {
                        nums += a % 10;
                        a /= 10;
                    }
                    if (nums==6)
                    {
                        number = i;
                    }
                }
                nums = 0;
            }
            Console.WriteLine(number);
        }
    }
}
