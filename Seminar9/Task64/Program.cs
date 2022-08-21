/*
Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 5, 6, 7, 8""
*/
System.Console.Write("Введите требуемый промежуток  \nВведите через пробел: ");
string[] input1 = Console.ReadLine().Split();
int num1 = int.Parse(input1[0]);
int num2 = int.Parse(input1[1]);
GetSum(num1, num2);

void GetSum(int n1, int n2)
{
    if (n1 > n2)
    {
        return;
    }
    Console.Write(n1 + " ");
    GetSum(++n1, n2);
}