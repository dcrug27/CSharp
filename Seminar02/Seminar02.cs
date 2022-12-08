using static MyLibrary;
public static class Seminar02
{
    /// <summary>
    /// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
    /// </summary>
    public static void Ex37()
    {
        //0. Метод считывания числа от пользователя
        //1. Метод создания массива
        //2. Метод заполнения массива
        //3. Метод печатати массива
        //4. Метод подсчета принадлежности элементов отрезку [10;99]

        int size = Input("Сколько чисел в массиве:");
        int[] arr = CreateArray(size);
        Fill(arr, 10, 100);
        Console.WriteLine(PrintArray(arr));
        Console.WriteLine(Counter(arr, 10, 99));
    }
}
