// Напишите программу, которая
// 1. На вход принимает число (N)
// 2. А на выходе показывает все четные числа от 1 до number

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int x = 2;

if (number > 1)
{
    while (x <= number)
    {
        Console.Write(x + "");
        x = x + 2;
    }
}











