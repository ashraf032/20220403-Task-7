using System;
using System.Linq;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i%11==0)
                {
                    //Console.WriteLine($"Ededimiz: {i}");
                    //Console.WriteLine("------");
                    int result = i.ToString().Sum(c => c - '0');
                    if (result >11)
                    {
                        count++;
                        if (count == 11)
                        {
                            Console.WriteLine($"Sherte uygun bolunen {count}-ci ededin reqemler cemi: {result}  Eded: {i} ");
                            break;
                        }

                    }

                }
            }
        }
    }
}
