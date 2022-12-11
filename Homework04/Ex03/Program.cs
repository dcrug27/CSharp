void FillArray(int[] zero) //Заполнение массива
{
    for (int i = 0; i < zero.Length; i++)
    {
        zero[i] = new Random().Next(0, 15);
    }
}

void PrintArray(int[] one) //Вывод массива
{
    for (int i = 0; i < one.Length; i++)
    {
        Console.Write(one[i] + " ");
    }
}

//Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15
//N: 3 [9, 4, 12] => 2097

Console.Write("Кол-во элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

FillArray(array);
PrintArray(array);
int powwe = array.Length - 1;
double output = 0;


for (int i = 0; i < array.Length; i++)
{
    double result = array[i] * Math.Pow(15, powwe);
    powwe--;
    output = output + result;
}
Console.Write($"-> {output}");