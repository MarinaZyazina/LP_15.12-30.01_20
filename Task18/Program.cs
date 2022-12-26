// Напишите программу, которая
// по заданному номеру четверти показывает 
// диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");

string quarter = Console.ReadLine();
string result = QuarterCoordinatePlane(quarter);
Console.WriteLine(result);

string QuarterCoordinatePlane(string number)
{
    if (number == "1") return "x > 0; y > 0";
    if (number == "2") return "x < 0; y > 0";
    if (number == "3") return "x < 0; y < 0";
    if (number == "4") return "x > 0; y < 0";
    return "Некорректные данные";
}