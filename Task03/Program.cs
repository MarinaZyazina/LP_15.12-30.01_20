// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
string a = Console.ReadLine();
if (a == "1") Console.WriteLine("Понедельник");
else if (a == "2") Console.WriteLine("Вторник");
else if (a == "3") Console.WriteLine("Среда");
else if (a == "4") Console.WriteLine("Четверг");
else if (a == "5") Console.WriteLine("Пятница");
else if (a == "6") Console.WriteLine("Суббота");
else if (a == "7") Console.WriteLine("Воскресенье");
else Console.WriteLine("Неверно введены данные");