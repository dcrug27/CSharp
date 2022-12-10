//Вид 1
void Method1()
{
    Console.WriteLine("Author Vadim Matveev");
}
Method1();// Вызвать метод 

//Вид 2
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
Method2(msg: "Text message");

//Вид 2.1
void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2_1("Text message", 4); // Method2_1(msg: "text", count: 4) - Можно так.

//Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//Вид 4
string Method4(int count, char text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, 'q');
Console.WriteLine(res);

//Вид 4.1

string Method4_1(int count, char text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res1 = Method4_1(10, 'q');
Console.WriteLine(res);
