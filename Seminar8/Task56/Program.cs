/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

void SumOfRowElements(int[,] array)
{
    int minSum = 0;
    int stringNumber = 0;
    int sumArray = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArray += array[i, j];
        }
        if (i == 0)
        {
            minSum = sumArray;
        }

        if (minSum > sumArray)
        {
            minSum = sumArray;
            stringNumber = i;
        }

        Console.WriteLine(sumArray); // Проверка для себя
        sumArray = 0;
    }
    Console.WriteLine($"\nНаименьшая сумма чисел в массиве в строке № {stringNumber + 1}");
}
Console.WriteLine("Введите размер двумерного массива через пробел: ");
string[] input = Console.ReadLine().Split(' ');
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);

SumOfRowElements(GetArray(row, col));