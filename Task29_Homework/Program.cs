// Напишите программу, которая 
// задаёт массив из 8 элементов и 
// выводит их на экран.
// Пример: 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Введите минимальное значение диапазона: ");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение диапазона: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(8, minNumber, maxNumber);
PrintArray(array);

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.Write(arr[i]);
        }
        else Console.Write(arr[i] + ", ");
    }
    Console.Write("]");
}