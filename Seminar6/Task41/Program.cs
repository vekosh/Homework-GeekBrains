/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите колличество чисел: ");
int quantity = int.Parse(Console.ReadLine());
int[] massivNumbers = new int[quantity];

void InputNumbers(int quant)
{
    for (int i = 0; i < quant; i++)
    {
        System.Console.WriteLine($"Введите {i + 1} число: ");
        massivNumbers[i] = int.Parse(Console.ReadLine());
    }
}
int ComparisonNumbers(int[] massivNumbers)
{
    int count = 0;
    for (int i = 0; i < massivNumbers.Length; i++)
    {
        if (massivNumbers[i] > 0)
        {
            count++;
        }
    }
    return count;
}
InputNumbers(quantity);

Console.WriteLine($"Введено чисел больше 0: {ComparisonNumbers(massivNumbers)} ");