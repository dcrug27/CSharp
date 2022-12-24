using static MyLibrary;

public static class Homework07
{
    public static void Ex01()
    {
        int m = Input("Введите число m: ");
        int n = Input("Введите число n: ");
        double[,] array = Create2ArrayDouble(m, n);
        Fill2ArrayDouble(array);
        Print2ArrayDouble(array);
    }

    public static void Ex02()
    {
        int rows = Input("Введите индекс строки: ");
        int colums = Input("Введите индекс столбца: ");
        int[,] numbers = Create2Array(rows, colums);
        Fill2Array(numbers);
        Print2Array(numbers);

        if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
        else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");
    }

    public static void Ex03()
    {
        int rows = Input("Введите индекс строки: ");
        int colums = Input("Введите индекс столбца: ");
        int[,] numbers = Create2Array(rows, colums);
        Fill2Array(numbers);
        Print2Array(numbers);
        Mean(numbers);
    }
}