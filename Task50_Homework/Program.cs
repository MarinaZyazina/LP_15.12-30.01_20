// Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

Console.Write("Bведите номер строки элемента: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента: ");
int m = Convert.ToInt32(Console.ReadLine());

// int[,] array2D = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int[,] array2D = CreateMatrixRndInt(4, 5, -20, 20);
PrintMatrix(array2D);

if (n <= 0 || m <= 0)
{
    Console.WriteLine("Вы ввели неверные данные");
}

else if (n > array2D.GetLength(0) || m > array2D.GetLength(1))
{
    Console.WriteLine("Такого элемента в массиве нет");
}
else
{
    Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {array2D[n - 1, m - 1]}");
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4}  ");
        }
        Console.WriteLine("]");
    }
}