/*
Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Первое число = " + num1);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Второе число = " + num2);

if (num1 > num2)
{
    Console.Write("max = " + num1);
}
else if (num1 < num2)
{
    Console.Write("max = " + num2);
}