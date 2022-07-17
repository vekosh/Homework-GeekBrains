/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Введите цифру, которая обозначает день недели: ");
int num = int.Parse(Console.ReadLine());


if (num > 5 && num <= 7)
{
    Console.Write("Yes");
}
if (num >= 1 && num <= 5)
{
    Console.Write("No");
}
if (num <= 0 | num >= 8)
{
    Console.Write("Error!");
}
