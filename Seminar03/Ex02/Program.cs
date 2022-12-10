//// - Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int number = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <=number; i++)
{
    result = result * i;
}
Console.WriteLine(result);
