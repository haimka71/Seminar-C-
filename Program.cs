// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Console.Clear();

// int[] numbers = new int[10];                      // инициализируем массив из 10 элементов


// void FillArray(int[] array, int min, int max)     // метод заполнения массива
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max);    // заполняем массив случайными числами в диапазоне min, max, для контроля значений при вызове мин/макс равны 100/1000
//     }
// }

// int QuantityPositiveSymbols(int[] array)    //метод подсчета четных значений
// {
//     int quantity = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)             // по остатку от деления проверяем четность
//         {
//             quantity++;
//         }
//     }
//     return quantity;
// }

// void PrintArray(int[] array)                    // метод печати массива
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]}, ");   //добавляем запятую и пробел при выводе элемента массива
//     }
// }


// FillArray(numbers, 100, 1000);

// PrintArray(numbers);

// Console.WriteLine();
// Console.WriteLine();
// int quantity = QuantityPositiveSymbols(numbers);
// Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");





// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




Console.Clear();

Console.Write($"Введите количество элементов массива: ");
int MassnumberElements = Convert.ToInt32(Console.ReadLine()); 


int RandomNumbers(int MassnumberElements, int min, int max)
  {
  int[] randomNumbers = new int[MassnumberElements];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");


    for (int i = 0; i <randomNumbers.Length; i++ )
    {
      randomNumbers[i] = new Random().Next(min, max);


      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }


int randomNumbers =  RandomNumbers(MassnumberElements, 0, 100);


Console.WriteLine($"\nСумма элементов, находящихся на нечётных позициях: {randomNumbers}");
