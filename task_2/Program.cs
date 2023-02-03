//Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

int a = 25;
int b = 7;

int max = a;
int min = b;

if (b>max) max = b; 
else max = a;

if (b<max) min = b;
else min = a;

              
Console.Write("max= ");
Console.WriteLine(max);

Console.Write("min= ");
Console.WriteLine(min);
