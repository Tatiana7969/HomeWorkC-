// Напишите программу, которая 
// 1. выводит третью цифру заданного числа 
// 2. или сообщает, что третьей цифры нет 
// 645 -> 5
// 78 -> третьей цифры нет
// 32678 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = GetThirdDigit(number);

if (thirdDigit == -1)
{
    Console.WriteLine("Третьей цифры нет");
} 
else
{
    Console.WriteLine($"Третья цифра: {thirdDigit}");
}

int GetThirdDigit(int number)
{
    number = Math.Abs(number);
    if (number / 10!=0)
    {
        number = (number / 10) / 10 % 10;
        return number;
    }
   return-1;
   
}




