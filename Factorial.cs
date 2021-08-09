using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    class Factorial
    {
        public static void FindFactorial()
        {
            // 5! = 5*4*3*2*1 = 240
            int num = 20; // Get the factorial of 5.
            var result = 1;
            var pattern = new int[num];
            for(int i =num; i >= 1; i--)
            {
                result = result * i;
                pattern[num - i] = i ;
            }
            Console.WriteLine("Factorial of Number-{0} :", num+"!");
            //Prints the pattern
            for(int i = 0; i<pattern.Length;i++ )
            {
                Console.Write(pattern[i].ToString());
                if(i != (pattern.Length -1))
                {
                    // * should not be displayed for last digit
                    Console.Write("*");
                }
              
            }
            Console.WriteLine();
            Console.WriteLine("Value is :"+result);

        }
    }
}
