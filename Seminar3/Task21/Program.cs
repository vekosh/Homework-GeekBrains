/*
Напишите программу, которая принимает на 
вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.Write("Введите число x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите число y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите число z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите число x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите число y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите число z2: ");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine("Длина отрезка = " + Math.Round(getLength(x1,y1,z1,x1,y2,z2),2));

double getLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return distance;
}