// Напишите программу, которая 
// принимает на вход число и
// выдаёт количество цифр в числе.
// Примеры: 456 -> 3; 78 -> 2; 89126 -> 5

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
// -if (number < 0) number = - number; мое добавление, другая реализация в цикле
int digitsInNumber = DigitsInNumber(number);
Console.WriteLine($"Количество цифр в числе {digitsInNumber}");

int DigitsInNumber(int digit)
{
    int count = 0;
    while (digit != 0)  // != (не равно)
    {
        digit = digit / 10;
        count = count + 1;
    }
    return count; 
}

// не подходит для "0", выдаст 0