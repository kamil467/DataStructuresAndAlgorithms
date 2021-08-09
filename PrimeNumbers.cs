using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public static class PrimeNumbers
    {
        public static void SumPrimeNumbers()
        {
            // Prime number qualification.
            // They can be divided by only themselves. eg : 2/2 =0 , 5/5 =0;
            int num = 100;// take prime numbers upto 10.
            int sum = 0;
            for(int i = 2; i<=num; i++)  // 2 is a first prime number so starting from two.
            {
                var counter = 0;
               for(int j = 2;j<= i; j++) // J loop doesn't need to run for upto all numbers.It
                                         // It will run upto outerloop i.
                {
                    if(i%j == 0)
                    {
                        counter++;
                    }
                    if (counter > 1)
                    {
                        break;
                    }
                }
               if(counter == 1)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    sum = sum + i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Prime Number sum is:" + sum);
        }
    }
}
