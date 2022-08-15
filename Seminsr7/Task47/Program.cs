/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] GetArray(int row, int col)
{
    double[,] array = new double[row, col];
    double doub = 0;
    double num = 0;
    Random rndDoub = new Random();
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            doub = rndDoub.NextDouble();
            num = rndNum.Next(0, 10);
            array[i, j] = doub + num;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round((array[i, j]),2) + "\t");
        }
        Console.WriteLine();
    }
}

void SubtractionInArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] -= 5;
        }
    }
}

Console.WriteLine("Введите размер двумерного массива через пробел: ");
string[] input = Console.ReadLine().Split(' ');
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);
double[,] myArray = GetArray(row, col);
SubtractionInArray(myArray);
PrintArray(myArray);