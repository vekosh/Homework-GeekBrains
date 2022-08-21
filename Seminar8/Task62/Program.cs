/*
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1  2  3  4
12 13 14 5
11 16 15 6
10 9  8  7
*/
Console.WriteLine("Заполните спирально массив 4 на 4");

int value = 1;
int x = 4;
int y = 4;

int[,] array = new int[x, y];
int k = array.GetLength(1) - 1;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == 0)
        {
            array[i, j] = value;
            value++;
        }

        else if (i != 0 & i != array.GetLength(1) - 1)
        {
            array[i, k] = value;
            value++;
            j = array.GetLength(1);
        }

        else if (i == array.GetLength(0) - 1)
        {
            array[i, k] = value;
            value++;
            k--;
        }
    }
}
int firstAndLastStringCount = 2;
int firstStringCount = 1;
for (int i = array.GetLength(0) - firstAndLastStringCount; i >= firstStringCount; i--)
{
    array[i, 0] = value;
    value++;
}

for (int i = 1; i < 2; i++)
{
    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
        array[i, j] = value;
        value++;
    }
}

for (int i = array.GetLength(0) - 2; i < array.GetLongLength(0) - 1; i++)
{
    for (int j = array.GetLength(1) - 2; j > 0; j--)
    {
        array[i, j] = value;
        value++;
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}