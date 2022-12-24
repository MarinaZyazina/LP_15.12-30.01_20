// Напишите программу, которая будет 
// принимать на вход два числа и 
// выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// Пример: 34, 5 -> не кратно, остаток 4
// Пример: 16, 4 -> кратно

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// bool result = firstNumber % secondNumber == 0;

// if (result) Console.Write($"Число {firstNumber} кратно {secondNumber}");
// else Console.Write($"Число {firstNumber} не кратно {secondNumber}, остаток {firstNumber % secondNumber}");

// вариант 2 - с исп. метода

int result = Multiplicity(firstNumber, secondNumber);
Console.WriteLine(result == 0 ? "Кратно" : $"Не кратно, остаток от деления {result}");

int Multiplicity(int firstNum, int secondNum)
{
    return firstNum % secondNum;
}


