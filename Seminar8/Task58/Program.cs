/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/

int[,] array1 =
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7}
};
Console.WriteLine("Матрицу №1");
PrintArray(array1);

int[,] array2 =
{
    {1, 5, 8, 5},
    {4, 9, 4, 2},
    {7, 2, 2, 6},
    {2, 3, 4, 7}
};

int[,] resultMultiplicationArray = new int[4, 4];

Console.WriteLine("\nУмножаем на матрицу №2:\n");

PrintArray(array2);

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < array2.GetLength(0); k++)
        {
            sum += array1[i, k] * array2[k, j];
        }
        resultMultiplicationArray[i, j] = sum;
    }
}
Console.WriteLine("\nРезультатом умножения является матрица:\n");

PrintArray(resultMultiplicationArray);
       

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}