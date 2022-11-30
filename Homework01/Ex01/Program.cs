//

int a = 2;
int b = 3;
int c = 7;

int max = 0;

if (a > b && a > c)
{
    max = a;
}
else
{
    if (b > c)
    {
        max = b;
    }
    else
    {
        max = c;
    }
}

Console.WriteLine(max);