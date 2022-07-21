/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Вы ввели следующее значение: " + num);

newPalindrom(num);
void newPalindrom(int num)
{
    int FirstFormula = num % 10;
    int SecondFormula = num / 10000;
    if (FirstFormula == SecondFormula)
    {
        FirstFormula = num / 1000 % 10;
        SecondFormula = num / 10 % 10;
    }
    if (FirstFormula == SecondFormula)
    {
        Console.Write("Является палиндромом " + num);
    }
    else
        Console.Write("Не является палиндромом" + num);
}