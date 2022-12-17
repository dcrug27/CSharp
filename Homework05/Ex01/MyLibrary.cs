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
            output += $"{array[i], 3} ";
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
        for (int i = 1; i < array.Length; i+=2)
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

    public static void FillArrayDouble(double[] array,int min,int max)
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
            output += $"{array[i], 3} ";
        }
        return output;
    }
}