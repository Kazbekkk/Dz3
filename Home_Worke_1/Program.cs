/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

int number, numberWhile, result = 0;

Console.Write("Введите число: ");
number = Int32.Parse(Console.ReadLine());
numberWhile = number;

while (numberWhile > 0)
{
    result *= 10;
    result += numberWhile % 10;
    numberWhile /= 10;
}

if (number / result == 1)
{
    Console.WriteLine($"{result} является палиндромом числа {number}");
}

else
{
    Console.WriteLine($"{result} не является палиндромом числа {number}");
}

