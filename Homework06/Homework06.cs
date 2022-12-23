using static MyLibrary;

public static class Hw06
{
    public static void Ex01()
    {
        int count = Input("Сколько чисел в массиве: ");
        int[] array = CreateArray(count);
        FillArrayHand(array);
        System.Console.WriteLine($"{PrintArray(array)} -> {HowNumbersMoreZero(array)}");
    }

    public static void Ex02()
    {
        double b1 = Input("Введите число b1: ");
        double k1 = Input("Введите число k1: ");
        double b2 = Input("Введите число b2: ");
        double k2 = Input("Введите число k2: ");
        double x = Intersection(b1, k1, b2, k2);
        double y = k1 * x + b1;
        System.Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}, {y})");
    }
}