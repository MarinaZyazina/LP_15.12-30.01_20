// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите первое положительное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе положительное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({firstNumber}, {secondNumber}) = {AckermannFunction(firstNumber, secondNumber)}");

int AckermannFunction(int firstNum, int secondNum)
{
    if (firstNum == 0)
        return secondNum + 1;
    if (firstNum > 0 && secondNum == 0)
        return AckermannFunction(firstNum - 1, 1);
    else
        return AckermannFunction(firstNum - 1, AckermannFunction(firstNum, secondNum - 1));
}
