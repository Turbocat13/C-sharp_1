// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
int a = 22;
int b = 3;
int c = 9;

int max = a;

if (b>max)max = b;
if (c>max)max = c;

Console.Write("max= ");
Console.WriteLine(max);

