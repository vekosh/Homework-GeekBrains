/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.WriteLine("Введите значение b1: ");
double meaningB1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double meaningK1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double meaningB2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double meaningK2 = double.Parse(Console.ReadLine());
double x, y;
x = (meaningB2 - meaningB1) / (meaningK1 - meaningK2);
y = meaningK1 * x + meaningB1;
Console.Write($"Точка пересечения двух прямых:  ({x}; {y})");
