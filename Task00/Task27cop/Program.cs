// Напишите программу, которая
// 1. принимает на вход число
// 2. выдает сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int abc = Convert.ToInt32(Console.ReadLine());
int value = abc;
int i = 0;
int sum = 0;
while (value > 0)
{
    i = value % 10;
    sum = sum + i;
    value = value / 10;
}
Console.WriteLine($"Сумма цифр" + sum);








