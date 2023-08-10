// 1. Задайте массив вещественных чисел.
// 2. Найдите разницу между max и min
// элементами массива
// [3.22,4.2,1.15,77.15,65.2] -> 77.15 - 1.15 = 76

int size = 5;
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

double max = numbers[0];
double min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine($"Минимальный элемент: {min}");
Console.WriteLine($"Максимальный элемент: {max}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");

void FillArrayRandomNumbers(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "   ");
    }
    Console.WriteLine();
} 
   





