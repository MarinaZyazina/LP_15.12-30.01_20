// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.WriteLine("Введите первое натуральное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NaturalNumbersSum(firstNumber, secondNumber));

int NaturalNumbersSum(int firstNum, int secondNum)
{
    if (firstNum == secondNum) return secondNum;
    else if (firstNum < secondNum) return secondNum + NaturalNumbersSum(firstNum, secondNum - 1);
    else return (firstNum + NaturalNumbersSum(secondNum, firstNum - 1));
}
