using static MyLibrary;
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int x1 = Input("Введите x1: ");
int y1 = Input("Введите y1: ");
int x2 = Input("Введите x2: ");
int y2 = Input("Введите y2: ");

int x3 = x2 - x1;
int y3 = y2 - y1;

double distance = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));

Console.WriteLine(Math.Round(distance, 1));