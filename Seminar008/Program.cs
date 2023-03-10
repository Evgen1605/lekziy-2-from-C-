// Напишите программу,
// которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
// double s = Math.Sqrt(...); // библеотека Math метод Sqrt()- который вернёт корень выражения записанный в скобки

Console.Clear();
Console.Write("Введите координату X1: ");// просим пользователя ввести координаты 
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату X2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y2: ");
int y2 = int.Parse(Console.ReadLine()!);

//double s = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));// согласно формуле написаной выше разница координат X-ов умноженная на разница координат X-ов (это так возводится во вторую степень) к этому результату прибавляем разница координат Y-ов умножаем на разница координат Y-ов
double s = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));// создаём переменную double s, т.к у нас должно выводится дробное число Math.Pow()- возводит в степень, первым аргументом даётся число, а вторым через запятую в какую степень вводить число, например Math.Pow(5, 3) это 5 в степени 3
Console.WriteLine($"Расстояние  = {s:f3}");// результат действий выводим в консоль, :f3- означает сколько символов после запятой будет выводиться  