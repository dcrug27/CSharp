// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
int rev = 0;

while (number > 0)
{
    int dig = number % 10;
    rev = rev * 10 + dig;
    number = number / 10;
}
if (temp == rev)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");    
}