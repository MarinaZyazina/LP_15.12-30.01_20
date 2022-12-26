// Напишите программу, которая
// принимает на вход число (N) и
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25;
// 2 -> 1, 4

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0)
{
TableSquare(number);    
}
else Console.WriteLine("Не натуральное число");

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,4} {Math.Pow(count, 2),4}"); // 4-отступ-форматирование (можно 5,6...)
        count++;
    }
}