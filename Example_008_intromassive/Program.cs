int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if (arg2 > result) result = arg2;
if (arg3 > result) result = arg3;
return result;
}

int a1 = 15;
int b1 = 43;
int c1 = 22;
int a2 = 5;
int b2 = 6334;
int c2 = 25;
int a3 = 1;
int b3 = 2;
int c3 = 3;

int max = Max 
(Max(a1, b1, c1), 
Max(a2, b2, c2), 
Max(a3, b3, c3));
Console.WriteLine(max);