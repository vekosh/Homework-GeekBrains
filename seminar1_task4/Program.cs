/*
 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Первое число = " + num1);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Второе число = " + num2);
Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine("Третье число = " + num3);

int num4 = 0;

if (num1 > num2)
{
    num4 = num1;
}
else if (num1 < num2)
{
     num4 = num2;
}
if (num3 > num4)
{
    Console.Write("max = " + num3);
}
else if (num3 < num4)
{
    Console.Write("max = " + num4);
}