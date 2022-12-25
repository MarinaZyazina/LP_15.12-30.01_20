// Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// Примеры: 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = - number;

// int numberOriginal = number;
// if (number < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     while (number > 999)
//     {
//         number = (number - number % 10) / 10;
//     }
//     int result = number % 10;
//     Console.WriteLine($"Результат из {numberOriginal} => {result}");
// }


Console.WriteLine(number < 100 ? "Третьей цифры нет" : ThirdDigit(number));

int ThirdDigit(int num)
{
    while (num > 999)
    {
        num = (num - num % 10) / 10;
    }
    int result = num % 10;
    return result; 
}