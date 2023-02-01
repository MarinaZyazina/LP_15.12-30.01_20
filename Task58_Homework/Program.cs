// Задайте две матрицы. 
// Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] firstMatrix = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(firstMatrix);
Console.WriteLine(String.Empty);
int[,] secondMatrix = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(secondMatrix);

if(firstMatrix.GetLength(1) == secondMatrix.GetLength(0)) 
{
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(MultiplyMatrix(firstMatrix, secondMatrix));   
}
else
{
Console.WriteLine($"Матрицы нельзя умножить, т.к. число столбцов первой матрицы не равно числу строк второй.");
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}

int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
  int[,] resultMatrix = new int[secondMatrix.GetLength(0), firstMatrix.GetLength(1)];
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
  return resultMatrix;
}
