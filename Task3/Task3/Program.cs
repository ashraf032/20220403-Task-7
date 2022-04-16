using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100000; i++)
            {
                int j = i;
                int lastj = j % 10;
                int sum = 0;
                bool state = false;
                while (j>0)
                {
                    sum = sum + j % 10;
                    if (j%10!=lastj||j%10==5)
                    {
                        state = true;
                        break;
                    }
                    j /= 10;

                }
                if (!state&&sum>5)
                {
                    Console.WriteLine(i);

                }

            }
        }
    }
}
