// Напишите программу, которая на вход
// 1. Принимает трехзначное число
// 2. На выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = (number / 10) % 10;

Console.WriteLine($"Вторая цифра числа: {secondDigit}");

