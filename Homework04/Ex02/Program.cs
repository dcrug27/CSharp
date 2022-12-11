//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
//Строки использовать нельзя

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;

double count = Math.Log10(number);
    for (int i = 0; i < count ; i++)
    {
        int a = number / 10;
        int b = number % 10;
        number = a;
        result = result + b;
    }
System.Console.WriteLine(result);