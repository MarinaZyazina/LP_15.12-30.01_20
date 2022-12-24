// Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// Например, 78 -> 8; 12-> 2; 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// вариант 1
// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра числа => {secondDigit}");
// }

// или вариант 2 
// тернарный оператор (? тогда; : иначе)
// Console.Write($"Наибольшая цифра числа => ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

// или вариант 3
// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа => {result}");

// вариант 4 с использованием метода. вернуть из метода return
// Смысл: 1. позволяет идентифицировать задачу; читаемость кода,
// модульность разработки;
// 2. использовать многократно, вызывать из любого места программы

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");

int maxDigit1 = MaxDigit(45);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit1}"); // пример (45)

int maxDigit2 = MaxDigit(78);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit2}"); // пример (78)

int MaxDigit(int num) // num = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}
// можно без ввода переменной result
// return firstDigit > secondDigit ? firstDigit : secondDigit;