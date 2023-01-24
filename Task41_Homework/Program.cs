// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Примеры: 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите целые числа (через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int countPositiveNumbers = CountPositiveNumbers(array);
Console.WriteLine($"Количество чисел больше 0 = {countPositiveNumbers}");

int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}
