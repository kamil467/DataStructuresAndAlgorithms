using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public static class HackerEarth
    {
        public static void RepeatedDecimal()
        {
            var numerator = Int32.Parse(Console.ReadLine());
            var denom = Int32.Parse(Console.ReadLine());

            if (numerator % denom == 0)
            {
                // Print the value for perfect division.
                Console.WriteLine(numerator / denom);
            }
            else
            {
                // to get a decimal value from two integers , need to convert the tyoe of variable
                // into double.
                double value = (double)numerator/ (double)denom; // decimal value.
                var valueString = value.ToString().Split('.');
                var decimalPart = valueString[1];
                var isRepeated = true;

                if (decimalPart.Length > 1)
                {



                    for (int i = 0; i < decimalPart.Length; i++)
                    {

                        for (int j = 0; j < decimalPart.Length; j++)
                        {
                            if (decimalPart[i] != decimalPart[j])
                            {
                                isRepeated = false;
                            }
                        }

                    }
                    if (isRepeated)
                    {
                        Console.WriteLine(valueString[0] + "." + "(" + decimalPart[0] + ")");
                    }
                }
                else
                {
                    //Print same as it is for non repeated decimal
                    Console.WriteLine(value);
                }

            }
        }
    }
}

