using static MyLibrary;

public static class Hw08
{
    public static void Ex01()
    {
        int rows = Input("Введите индекс строки: ");
        int colums = Input("Введите индекс столбца: ");
        int[,] array = Create2Array(rows, colums);
        Fill2Array(array);
        Print2Array(array);
        Sort(array);
        System.Console.WriteLine(" ");
        Print2Array(array);
    }
    
    public static void Ex02()
    {
        int rows = Input("Введите индекс строки: ");
        int colums = Input("Введите индекс столбца: ");
        int[,] array = Create2Array(rows, colums);
        Fill2Array(array);
        Print2Array(array);
        MinSumElements(array);
    }

    public static void Ex03()
    {
        int[,,] array = CreateArray3D(2, 2, 2);
        Fill3DArray(array);
        Print3DArrayIndex(array);
    }
}