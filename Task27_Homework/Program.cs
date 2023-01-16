// Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.
// Примеры: 452 -> 11; 82 -> 10; 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
int sumOfDigits = SumOfDigits(number);
Console.WriteLine($"Сумма цифр в числе {sumOfDigits}");

int SumOfDigits(int num)
{
    int result = 0;
    int temp = 0;
    while (num > 0)
    {
        temp = num % 10;
        num = num / 10;
        result = result + temp;
    }
    return result;
}