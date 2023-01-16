// Напишите программу, которая 
// выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// Пример [1,0,1,1,0,1,0,0]

// ТЕОРИЯ
// Способы инициализации массива
// int[] array = new int[8];
// основной способ, индексация с 0, по умолчанию массив заполнен нулями

// int[] array1 = new int[8] { 5, 2, 6, 8, 7, 0, 3, 1 };
// int[] array1 = new int[] { 5, 2, 6, 8, 7 };
// int[] array1 = { 5, 2, 6, 8, 7 };

// array[7] = 235; // присвоить значение элементу массива с индексом 7 

// Console.WriteLine(array[7]);  // обратиться к элементу массива по индексу

// // используем цикл for
// for (int = 0; i < array.Length; int++)
// {
//     array[i] = 2; // при таком условии массив заполниться 2
// }


int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    Random rnd = new Random(); // в любой системе гантированнно получать случайные числа 
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}