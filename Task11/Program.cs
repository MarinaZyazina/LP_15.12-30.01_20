// Напишите программу, которая 
// 1. выводит случайное трёхзначное число и 
// 2. удаляет вторую цифру этого числа.
// Примеры: 456 -> 46; 782 -> 72; 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");

int firstDigit = number / 100;
int thirdDigit = number % 10;

int result = firstDigit*10+thirdDigit;
Console.WriteLine($"Результат из {number} => {result}");