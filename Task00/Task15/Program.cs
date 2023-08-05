// Напишите программу, которая
// 1. Принимает на вход цифру, обозначающую день недели
// 2. Проверяет, является ли этот день недели выходным
// 6 -> да
// 7 -> да
// 1 -> нет 

Console.WriteLine("Введите цифру, обозначающую день недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void ChekingTheDayWeek (int number)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Выходной");
    }
    else if (dayNumber  > 1 || dayNumber < 7)
    {
        Console.WriteLine("Будни");
    }
}
ChekingTheDayWeek(dayNumber);

