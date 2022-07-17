/*
 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Вы ввели слежующее значение: " + num);

if (num < 100)
{
    Console.WriteLine("Ошибка!");
}
else
{
    while (num > 999)
    {
        num = num / 10;
    }
    num = num % 10;
    Console.Write("Третье число = " + num);
}