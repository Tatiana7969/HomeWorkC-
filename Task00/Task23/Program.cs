// Напищите программу, которая
// 1. принимает на вход число (N)
// 2. и выдает таблицу кубов чисел от 1 до N
// 5 ->
// 1|1
// 2|8
// 3|27
// 4|64
// 5|125

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некорректные данные");
}
CubeTable (number);

void CubeTable (int num)
{
    for (int i = 1; i <= num; i++)
    {
        int cube = i*i*i;
        Console.WriteLine($"{i}   {cube}");
    }
}

