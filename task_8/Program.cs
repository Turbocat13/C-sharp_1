﻿//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число для проверки: ");
int allNumb = int.Parse(Console.ReadLine()!);
int count = 1;
while (count <= allNumb)
    {
      if (count %2==0)
             {
                 Console.Write($"{count}");
             }
          count++;
    }
      


    



