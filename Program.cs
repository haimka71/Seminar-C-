// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Clear();

int[] numbers = new int[10];                      // инициализируем массив из 10 элементов


void FillArray(int[] array, int min, int max)     // метод заполнения массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);    // заполняем массив случайными числами в диапазоне min, max, для контроля значений при вызове мин/макс равны 100/1000
    }
}

// void WriteArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " "); //добавляем пробел при выводе элемента массива
//     }
//     Console.WriteLine();
// }


int QuantityPositiveSymbols(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)             // по остатку от деления проверяем четность
        {
            quantity++;
        }
    }
    return quantity;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");   //добавляем запятую и пробел при выводе элемента массива
    }
}


FillArray(numbers, 100, 1000);

PrintArray(numbers);

// WriteArray(numbers);

Console.WriteLine();
Console.WriteLine();
int quantity = QuantityPositiveSymbols(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");

