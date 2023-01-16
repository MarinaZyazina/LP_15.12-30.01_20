// Напишите программу, которая
// принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// примеры: 7 -> 28; 4 -> 10; 8 -> 36

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i; // или sum += i; (короткая запись)
    }
    return sum;
}