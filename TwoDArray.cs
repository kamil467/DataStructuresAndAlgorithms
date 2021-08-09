using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    /// <summary>
    /// Program to convert NxM two D Array into MxN array.
    /// </summary>
    /// Sample INput
    /// 3 5    --> where 3 = n & 5 = m
// 13 4 8 14 1
//9 6 3 7 21
//5 12 17 9 3
//output 
//13 9 5
//4 6 12
//8 3 17
//14 7 9
//1 21 3
    class TwoDArray
    {
        public static void Matrix()
        {
            var firstLine = Console.ReadLine().Split(' ');
            var n = Convert.ToInt32(firstLine[0]);
            var m = Convert.ToInt32(firstLine[1]);

            int[,] array_two = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                var rowData = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)
                {
                    //Console.Write("Data is :"+Int32.Parse(rowData[j]));
                    array_two[i, j] = Int32.Parse(rowData[j]);
                }
            }

            int[,] newArray = new int[m, n];
            for (int k = 0; k < m; k++)
            {
                for (int l = 0; l < n; l++)
                {
                    newArray[k, l] = array_two[l, k];
                    Console.Write(newArray[k, l]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
