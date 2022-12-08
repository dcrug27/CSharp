/// <summary>
/// Это библиотека для работы с массивами
/// <para>Метод создания массива - CreateArray</para>
/// <para>Метод заполнения массива - Fill</para>
/// </summary>
public static class MyLibrary
{
    //0. Метод считывания числа от пользователя
    public static int Input(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    /// <summary>
    /// Метод создания массива
    /// </summary>
    /// <param name="count"> Количество элементов нового массива </param>
    /// <returns>Созданный массив из count элементов</returns>
    public static int[] CreateArray(int count)
    {
        return new int[count];
    }

    //2.Метод заполнения массива
    public static void Fill(int[] array, int min, int max)
    {
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(min, max);
        }
    }

    //3.Метод печати массива
    public static string PrintArray(int[] array)
    {
        string output = String.Empty;
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            output += $"{array[i],3}";
        }
        return output;
    }

    //4.Метод подсчета принадлежности элементов отрезку [10;99]
    public static int Counter(int[] array, int down, int up)
    {
        int result = 0;
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            if(array[i]>= down && array[i]<= up)
            {
                result++;
            }
        }
        return result;
    }

}
