// Напишите программу,
// которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
// double s = Math.Sqrt(...);

Console.Clear();
Console.Write("Введите координату X1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату X2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y2: ");
int y2 = int.Parse(Console.ReadLine()!);

double s = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
// double s = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
Console.WriteLine($"Расстояние  = {s:f3}");