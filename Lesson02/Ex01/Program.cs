// Максимальное из 9 чисел

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 11;
int b1 = 212;
int c1 = 33;
int a2 = 44;
int b2 = 555;
int c2 = 669;
int a3 = 77;
int b3 = 818;
int c3 = 9659;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));


System.Console.WriteLine(max);