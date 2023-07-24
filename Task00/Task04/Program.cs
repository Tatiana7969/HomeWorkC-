// Напишите программу, которая 
// 1. Принимает на вход три числа 
// 2. И выдает максимальное из этих чисел

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22


Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write ("max = ");
Console.WriteLine(max); 









