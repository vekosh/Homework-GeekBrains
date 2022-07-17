/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Вы ввели число = " + num);

int result = getSecondNumber(num);
Console.Write("Вторая цифра = " + result);

int getSecondNumber(int Number)
{
    int deleteDigitOne = num / 10;
    int deleteDigitTwo = deleteDigitOne % 10;
    return deleteDigitTwo;
}