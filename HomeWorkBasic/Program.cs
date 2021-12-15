using System;

namespace HomeWorkBasic
{
    class Program
    {
        static int MinValue(int[,] array)
        {
            var (i, j) = MinIndexArray(array);
            return array[i, j];
        }

        static int MaxValue(int[,] array)
        {
            var (i, j) = MaxIndexArray(array);
            return array[i, j];
        }

        static (int, int) MinIndexArray(int[,] array)
        {
            int minI = 0;
            int minJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[minI, minJ] > array[i, j])
                    {
                        minI = i;
                        minJ = j;
                    }
                }
            }

            return (minI, minJ);
        }

        static (int, int) MaxIndexArray(int[,] array)
        {
            int maxI = 0;
            int maxJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[maxI, maxJ] < array[i, j])
                    {
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            return (maxI, maxJ);
        }

        static int BiggerNeighborCount(int[,] array)
        {
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i > 0 && array[i, j] < array[i - 1, j])
                    {
                        continue;
                    }
                    if (i < array.GetLength(0) - 1 && array[i, j] < array[i + 1, j])
                    {
                        continue;
                    }
                    if (j > 0 && array[i, j] < array[i, j - 1])
                    {
                        continue;
                    }
                    if (j < array.GetLength(1) - 1 && array[i, j] < array[i, j + 1])
                    {
                        continue;
                    }
                    count++;
                }
            }

            return count;
        }

        static int[,] DiagonalRevers (int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j > i)
                    {
                        Swap(ref array[i, j], ref array[j, i]);
                    }

                }
            }

            return array;
        }

        static int[,] CreateDrawArray(int n, int m)
        {
            int[,] array = new int[n, m];
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 22);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                }
                Console.WriteLine();
            }

            return array;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main()
        {
            int n = 4;
            int m = 4;
            int[,] array = CreateDrawArray(n, m);

            Console.WriteLine();
            DiagonalRevers(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
