using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //polindrom meselesi
            for (int a = 10; a <= 1000; a++)
            {
                if (a < 100)
                {
                    if (a % 10 == a / 10)
                    {
                        Console.WriteLine(a);
                    }
                }
                if (a >= 100)
                {
                    if (a % 10 == a / 100)
                    {
                        Console.WriteLine(a);
                    }
                }
            }
        }
    }
}
