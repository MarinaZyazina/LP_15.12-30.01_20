// Напишите цикл, который 
// принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Примеры: 3, 5 -> 243 (3⁵); 2, 4 -> 16

Console.Write("Bведите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int numberToThePower = NumberToThePower(numberA, numberB);

Console.WriteLine(numberB <= 0 ? "Ненатуральное число" : $"Число {numberA} в степени {numberB} = {numberToThePower}");

int NumberToThePower(int numA, int numB)
{
int result = numA;
for (int i = 1; i < numB; i++)
{
    result = result * numA;
}
return result;
}