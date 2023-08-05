// Напишите цикл, который 
// 1. принимает на вход два числа (А и В)
// 2. возводит число А в натуральную степень в
// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());

int pow = 1;

for (int i = 0; i < B; i++)
{
    pow = pow * A;
}
Console.WriteLine($"A в натуральной степени B равно {pow}");