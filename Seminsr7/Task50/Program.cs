/*  
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
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
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер двумерного массива через пробел: ");
string[] input = Console.ReadLine().Split(' ');
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);

int[,] myArray = GetArray(row, col);
PrintArray(myArray);

Console.WriteLine("Введите позицию искомого эллемента через пробел: ");
string[] inputNum = Console.ReadLine().Split(' ');
int rowNum = int.Parse(inputNum[0]);
int colNum = int.Parse(inputNum[1]);

if (rowNum > row || colNum > col)
{
    Console.WriteLine(rowNum + " " + colNum + " Такой позиции в массиве нет");
}
else { Console.Write(myArray[rowNum, colNum]); }