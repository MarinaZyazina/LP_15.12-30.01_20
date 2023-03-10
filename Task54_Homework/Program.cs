// Задайте двумерный массив. 
// Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] matrix = CreateMatrixRndInt(4, 4, 1, 20);
PrintMatrix(matrix);
SortElementsOfRowsInMatrix(matrix);
Console.WriteLine(string.Empty);
PrintMatrix(matrix);

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("]");
    }
}

void SortElementsOfRowsInMatrix(int[,] matrixForChange)
{
    for (int i = 0; i < matrixForChange.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForChange.GetLength(1); j++)
        {
            for (int k = 0; k < matrixForChange.GetLength(1) - 1; k++)
            {
                if (matrixForChange[i, k] < matrixForChange[i, k + 1])
                {
                    int temp = matrixForChange[i, k + 1];
                    matrixForChange[i, k + 1] = matrixForChange[i, k];
                    matrixForChange[i, k] = temp;
                }
            }
        }
    }
}
