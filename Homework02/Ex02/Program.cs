// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    double count = Math.Log10(number);
    for (int i = 0; i < count - 3; i++)
    {
        int a = number / 10;
        number = a;
    }
    number = number % 10;
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
