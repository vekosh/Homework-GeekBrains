/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-99, 100);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("Введите размер массива:");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(numberOfElements);
PrintArray(array);

int summ = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
    {
        summ += array[i];
    }
}
System.Console.WriteLine(summ);