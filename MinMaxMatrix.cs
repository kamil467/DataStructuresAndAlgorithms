using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
   public class MinMaxMatrix
    {
        public static void MinMax()
        {
            var numberOfTestCase = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfTestCase; i++)
            {
                var testCase = Console.ReadLine().Split(' ');
                var n = Convert.ToInt32(testCase[0]);
                var m = Convert.ToInt32(testCase[1]);
                // read the matrix
                int[,] matrix = new int[n, m];
                int minimum = 0;
                int maximum = 0;
                int minX = 0;
                int minY = 0;
                int maxX = 0;
                int maxY = 0;

                for (int k = 0; k < n; k++)
                {
                    var rowString = Console.ReadLine().Split(' ');
                    for (int c = 0; c < m; c++)
                    {
                        matrix[k, c] = Int32.Parse(rowString[c]);
                        // Console.Write(matrix[k,c]);
                        // Console.Write(' ');
                    }
                    // Console.WriteLine();
                }

                // matrix data has been loaded.
                // find minimum and maximum

                for (int x = 0; x < n; x++)
                {

                    for (int y = 0; y < m; y++)
                    {
                        var nomin = false;
                        for (int a = 0; a < n; a++)
                        {

                            for (int b = 0; b < m; b++)
                            {
                                if (matrix[x, y] <= matrix[a, b])
                                {

                                }
                                else
                                {
                                    // no min
                                    nomin = true;
                                    break;
                                }

                            }
                            if (nomin)
                            {
                                break;
                            }

                        }
                        if (!nomin)
                        {
                            minimum = matrix[x, y];

                            minX = x;
                            minY = y;
                        }

                    }

                }

                // Finding the max 

                for (int x = 0; x < n; x++)
                {

                    for (int y = 0; y < m; y++)
                    {
                        var nomin = false;
                        for (int a = 0; a < n; a++)
                        {

                            for (int b = 0; b < m; b++)
                            {
                                if (matrix[x, y] >= matrix[a, b])
                                {

                                }
                                else
                                {
                                    // no min
                                    nomin = true;
                                    break;
                                }

                            }
                            if (nomin)
                            {
                                break;
                            }

                        }
                        if (!nomin)
                        {
                            maximum = matrix[x, y];
                            maxX = x;
                            maxY = y;
                        }

                    }

                }

                //Console.WriteLine("Minimum is :"+minimum +" index is :"+minIndex);
                //Console.WriteLine("maximum is :"+maximum +" index is :"+maxIndex);


                // finding the x, y of min and max;
                var safeCounter = 0;
                for (int x = 0; x < n; x++)
                {

                    for (int y = 0; y < m; y++)
                    {

                        if (matrix[x, y] == minimum || matrix[x, y] == maximum)
                        {
                            // this and x and y is unsafe.    
                            // set the unsafe rows  element to  0;

                            for (int j = 0; j < m; j++)
                            {
                                if (matrix[x, j] == minimum || matrix[x, j] == maximum)
                                {

                                }
                                else
                                {
                                    matrix[x, j] = 0;
                                }



                            }
                            // set the unsafe column to 0
                            for (int z = 0; z < n; z++)
                            {
                                if (matrix[z, y] == minimum || matrix[z, y] == maximum)
                                {

                                }
                                else
                                {
                                    matrix[z, y] = 0;
                                }

                            }

                        }
                    }

                }


                for (int x = 0; x < n; x++)
                {
                    for (int y = 0; y < m; y++)
                    {
                        //Console.WriteLine(matrix[x,y]);
                        if (matrix[x, y] > 0 && (matrix[x, y] != minimum && matrix[x, y] != maximum))
                        {
                            safeCounter++;
                        }
                    }
                }
                Console.WriteLine(safeCounter);
            }

        }
    }
}
