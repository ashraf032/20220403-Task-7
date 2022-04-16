using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int eded = 1235637;
            int rev = 0;
            int remind;
            int counter = 0;
            while (eded>0)
            {
                remind = eded % 10;
                if (remind!=5 && remind !=7)
                {
                    rev = rev * 10 + eded % 10;
                    counter++;
                }
                eded /= 10;
            }

            int first = (int)(rev / Math.Pow(10, counter - 1));
            int last = rev % 10;
            Console.WriteLine(rev);
            Console.WriteLine(counter);
            Console.WriteLine(first);
        }
    }
}
