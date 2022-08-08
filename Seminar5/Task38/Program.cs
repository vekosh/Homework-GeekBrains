/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
// Так как по заданию надо использовать вещественные числа, использую double или float
double[] GetArray(int n)
{
    double[] arr = new double[n];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите длину массива: ");
int chislaArray = int.Parse(Console.ReadLine());
double[] array = GetArray(chislaArray);
PrintArray(array);

double maxNumber = array[0];
double minNumber = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (maxNumber < array[i])
    {
        maxNumber = array[i];
    }
    if (minNumber > array[i])
    {
        minNumber = array[i];
    }
}
Console.WriteLine("Max " + maxNumber);
Console.WriteLine("Min " + minNumber);
double difference = maxNumber - minNumber;
Console.Write("Разница равна: " + difference);