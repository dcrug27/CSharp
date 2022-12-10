void FillArray(int[] zero)
{
    for (int i = 0; i < zero.Length; i++)
    {
        zero[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] one)
{
    for (int i = 0; i < one.Length; i++)
    {
        Console.Write(one[i] + " ");
    }
}

// - Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

FillArray(array);
PrintArray(array);

double des = 1;
double res = 0;
int sc = 7;
for (int i = 0; i < 8; i++)
{
    des = array[i] * Math.Pow(2, sc);
    res = res + des;
    sc = sc - 1;
}
System.Console.WriteLine("");
System.Console.WriteLine(res);