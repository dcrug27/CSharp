using static MyLibrary;
public static class Hw05
{
    public static void Ex01()
    {
        int size = Input("Сколько чисел в массиве:");
        int[] arr = CreateArray(size);
        FillArray(arr, 100, 1000);
        System.Console.WriteLine(PrintArray(arr));
        System.Console.WriteLine(Even(arr));
    }

    public static void Ex02()
    {
        int size = Input("Сколько чисел в массиве:");
        int[] arr = CreateArray(size);
        FillArray(arr, -100, 100);
        System.Console.WriteLine(PrintArray(arr));
        System.Console.WriteLine(Sum(arr));
    }

    public static void Ex03()
    {
        int size = Input("Сколько чисел в массиве:");
        double[] arr = CreateArrayDouble(size);
        FillArrayDouble(arr, 0, 100);
        System.Console.WriteLine(PrintArrayDouble(arr));
        System.Console.WriteLine(Diff(arr));
    }
}