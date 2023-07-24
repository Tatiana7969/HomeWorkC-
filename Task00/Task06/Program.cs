// Напишите программу, которая
// 1. На вход принимает число
// 2. И выдает , является ли число четным

// 4 -> да
// 7 -> нет
// -3 -> нет


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write("Да"); 
}

else
{
    Console.Write("Нет");
}
