// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// Примеры:
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int num1 = number / 10000 % 10;
// int num2 = number / 1000 % 10;
// int rev2 = number / 10 % 10;
// int rev1 = number % 10;
// int check = number / 10000;

// if (check < 1 || check > 9)
// {
//     Console.WriteLine("Введено неправильное число");
// }
// else if (num1 == rev1 && num2 == rev2)
// {
//     Console.WriteLine($"Число {number} палиндром");
// }
// else
// {
//     Console.WriteLine($"Число {number} не палиндром");
// }

int check = number / 10000;
if (check < 1 || check > 9) Console.WriteLine("Введено неправильное число");
else Console.WriteLine(Palindrom(number) ? "Да" : "Нет");

bool Palindrom(int num)
{
    int dig1 = num / 10000 % 10;
    int dig2 = num / 1000 % 10;
    int rev2 = num / 10 % 10;
    int rev1 = num % 10;
    return dig1 == rev1 && dig2 == rev2;
}