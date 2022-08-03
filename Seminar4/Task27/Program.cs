/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите значение: ");
int n = int.Parse(Console.ReadLine());
int summa = 0;
while (n != 0)
{
    int x = n % 10;
    summa = summa + x;
    n = n / 10;
}
Console.WriteLine(summa);
