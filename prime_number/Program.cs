using System;
using System.Threading;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("prime number between two number");
            for(i=1;i<=10; i++)
            {
                for(j=2;j<=i;j++)
                {
                    if (i % j == 0)
                        break;
                }
                if(i==j)
                {
                    Console.WriteLine(j);
                }
            }
          Console.ReadKey();
        }
    }
}
