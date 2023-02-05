// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5->не кратно, остаток 4
// 16, 4->кратно


Console.Clear();

int num1 = new Random().Next(10, 100);
int num2 = new Random().Next(1, 10);

if (num1 % num2 == 0)
{
  Console.WriteLine($"{num1}, {num2} -> кратно");
}else
{
  Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num1 % num2}");
}

Console.WriteLine("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 % number2 == 0)
{
  Console.WriteLine($"Число 1: {number1} кратно числу 2: {number2}");
}else
{
  double ost = number1 % number2;
  Console.WriteLine($"Число 1: {number1} не кратно числу 2: {number2}, остаток: {ost}");
}