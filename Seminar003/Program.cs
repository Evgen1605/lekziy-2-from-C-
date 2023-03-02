// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5->не кратно, остаток 4
// 16, 4->кратно


Console.Clear();

int num1 = new Random().Next(10, 100);// первое 2-х значное рандомное число от 10 до 99
int num2 = new Random().Next(1, 10);// второе рандомное число от 1 до 9

if (num1 % num2 == 0)// сравниваем если первое число делиться на второе без остатка
{
  Console.WriteLine($"{num1}, {num2} -> кратно");// то выводим в консоль
}else
{
  Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num1 % num2}");// если не делится, то выводим в консоль эту строку, где {num1 % num2} остаток первого числа
}


// Второе решение задачи
Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 % number2 == 0)
{
  Console.WriteLine($"Число 1: {number1} кратно числу 2: {number2}");
}else
{
  double ost = number1 % number2;
  Console.WriteLine($"Число 1: {number1} не кратно числу 2: {number2}, остаток: {ost}");
}