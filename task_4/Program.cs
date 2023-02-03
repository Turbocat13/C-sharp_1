// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
int a = 2;
int b = 3395;
int c = 7;

int max = a;

if (a>max)max = a;
if (b>max)max = b;
if (c>max)max = c;

Console.Write("max= ");
Console.WriteLine(max);

