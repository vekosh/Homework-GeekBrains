﻿/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Вы ввели число = " + num);

int a =  (num % 2);
if (a == 0)
{
    Console.Write(num + " - Является четным числом.");
}
else 
{
   Console.Write(num + " - Не является чётным числом.");
}
