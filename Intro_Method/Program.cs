﻿int a1 = 35;
int b1 = 89;
int c1 = 99;

int a2 = 76;
int b2 = 18;
int c2 = 35;

int a3 = 10;
int b3 = 91;
int c3 = 28;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) 
    {
        result = arg2;
    }
    if(arg3 > result) 
    {
        result = arg3;
    }
    return result;
}

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);
