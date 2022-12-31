public static class MyLibrary
{
    public static int Input(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int[] CreateArray(int count)
    {
        return new int[count];
    }

    public static void FillArray(int[] array, int min, int max)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max);
        }
    }

    public static string PrintArray(int[] array)
    {
        string output = string.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            output += $"{array[i],3} ";
        }
        return output;
    }

    public static int Even(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    public static int Sum(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        return sum;
    }

    public static double Diff(double[] array)
    {
        double max = array.Max();
        double min = array.Min();
        double dif = max - min;
        return dif;
    }

    public static double[] CreateArrayDouble(int count)
    {
        return new double[count];
    }

    public static void FillArrayDouble(double[] array, int min, int max)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max) + new Random().NextDouble();
        }
    }

    public static string PrintArrayDouble(double[] array)
    {
        string output = string.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            output += $"{array[i],3} ";
        }
        return output;
    }

    public static void FillArrayHand(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Input($"Введите {i} число массива: ");
        }
    }

    public static int HowNumbersMoreZero(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        return count;
    }

    public static double Intersection(double b1, double k1, double b2, double k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        return x;
    }

    public static double[,] Create2ArrayDouble(int a, int b)
    {
        return new double[a, b];
    }

    public static void Print2ArrayDouble(double[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                System.Console.Write($"{matr[i, j]} ");
            }
            System.Console.WriteLine();
        }
    }

    public static void Fill2ArrayDouble(double[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
            }
        }
    }

    public static int[,] Create2Array(int a, int b)
    {
        return new int[a, b];
    }

    public static void Print2Array(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                System.Console.Write($"{matr[i, j]} ");
            }
            System.Console.WriteLine();
        }
    }

    public static void Fill2Array(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(0, 10);
            }
        }
    }

    public static void Mean(int[,] arr)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            double sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, j];
            }
            Console.Write($"{Math.Round(sum / arr.GetLength(0), 1)} ");
        }
    }

    public static void MinSumElements(int[,] array)
    {
        int minRow = 0;
        int minSumRow = 0;
        int sumRow = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            minRow += array[0, i];
        }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
            if (sumRow < minRow)
            {
                minRow = sumRow;
                minSumRow = i;
            }
            sumRow = 0;
        }
        Console.Write($"{minSumRow + 1} строка");
    }

    public static void Sort(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k + 1];
                        array[i, k + 1] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }
    }

    public static void Fill3DArray(int[,,] array)
    {
        int random = new Random().Next(1, 50);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] += random;
                    random += 7;
                }
            }
        }
    }

    public static int[,,] CreateArray3D(int a, int b, int c)
    {
        return new int[a, b, c];
    }

    public static void Print3DArrayIndex(int[,,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.WriteLine();
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
                }
            }
        }
    }

    public static void NaturalNumbersRangeN1(int n)
    {
        if (n == 0) return;
        System.Console.Write($"{n} ");
        NaturalNumbersRangeN1(n - 1);
    }

    public static void SumNatNumbMN(int m, int n, int sum)
    {
        if (m > n)
        {
            System.Console.WriteLine(sum);
            return;
        }
        sum = sum + (m++);
        SumNatNumbMN(m, n, sum);
    }

    public static int AkkermanFunction(int m, int n)
    {
        if (m == 0) return n + 1;
        if (m != 0 && n == 0) return AkkermanFunction(m - 1, 1);
        if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
        return AkkermanFunction(m, n);
    }
}