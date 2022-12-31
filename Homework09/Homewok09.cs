using static MyLibrary;

public static class Hw09
{
    public static void Ex01()
    {
        int n = Input("Введите натуральное число: ");
        NaturalNumbersRangeN1(n);
    }

    public static void Ex02()
    {
        int m = Input("M: ");
        int n = Input("N: ");
        SumNatNumbMN(m, n, 0);
    }

    public static void Ex03()
    {
        int m = Input("M: ");
        int n = Input("N: ");
        System.Console.WriteLine(AkkermanFunction(m, n));
    }
}