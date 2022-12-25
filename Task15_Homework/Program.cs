// Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.
// Пример: 6 -> да; 7 -> да; 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int dayWeekNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayWeekNumber)
{
    if (dayWeekNumber == 6 || dayWeekNumber == 7)
    {
        Console.WriteLine("(это выходной день) -> да");
    }
    else if (dayWeekNumber < 1 || dayWeekNumber > 7)
    {
        Console.WriteLine("Неверно введена цифра, обозначающая день недели");
    }
    else Console.WriteLine("(это не выходной день) -> нет");  
}

CheckingTheDayOfTheWeek(dayWeekNumber);
