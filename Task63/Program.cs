// Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if (num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}

// // Стек (англ. stack — стопка) — абстрактный тип данных, 
// // представляющий собой список элементов, организованных по принципу LIFO 
// // (англ. last in — first out, «последним пришёл — первым вышел»).


// // Вывод от большего к меньшему (меняем местами две строки в методе).
// // Чаще всего принцип работы стека сравнивают со стопкой тарелок: 
// // чтобы взять вторую сверху, нужно снять верхнюю.
// Console.WriteLine("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// NaturalNumbers(number);

// void NaturalNumbers(int num)
// {
//     if (num == 0) return;
//     Console.Write($"{num} ");
//     NaturalNumbers(num - 1);
// }