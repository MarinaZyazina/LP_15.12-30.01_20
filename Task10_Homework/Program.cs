// Напишите программу, которая 
// принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// Примеры: 456 -> 5; 782 -> 8; 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 100;
int secondDigit = number / 10;

int result = secondDigit - firstDigit*10;

Console.WriteLine($"Результат из {number} => {result}");