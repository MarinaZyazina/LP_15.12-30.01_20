// Напишите программу, которая
// принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// Примеры: 4 -> 24; 5 -> 120

// Примечание: Факториал натурального числа N определяется 
// как произведение всех натуральных чисел от 1 до N включительно

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int factorial = Factorial(number);
Console.WriteLine($"Произведение от 1 до {number} = {factorial}");

int Factorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        checked // проверка на переполнение, выдаст ошибку System.OverflowException
        {
        result *= i;
        }
    }
    return result;
}

// нет проверки на правильность ввода натурального числа