// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8)
{
    if (number < 6)
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Да");
    }
}
else
{
    Console.WriteLine("Введите число от 1 до 7");
}