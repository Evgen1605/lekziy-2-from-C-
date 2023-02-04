// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Clear();

int num = new Random().Next(10, 100);
Console.WriteLine($"Num = {num}");
int num1 = num / 10;
int num2 = num % 10;
int max = num1;

if (num2 > max)
{
  max = num2;
}
Console.WriteLine($"Max = {max} ");