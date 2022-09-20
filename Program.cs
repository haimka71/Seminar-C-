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



// Console.Clear();

// Console.Write($"Введите количество элементов массива: ");
// int MassnumberElements = Convert.ToInt32(Console.ReadLine()); 


// int RandomNumbers(int MassnumberElements, int min, int max)
//   {
//   int[] randomNumbers = new int[MassnumberElements];
//   int sumElements = 0;
//   Console.Write("Получившийся массив: ");


//     for (int i = 0; i <randomNumbers.Length; i++ )
//     {
//       randomNumbers[i] = new Random().Next(min, max);


//       Console.Write(randomNumbers[i] + " ");

//       if (i % 2 != 1)
//       {
//         sumElements = sumElements + randomNumbers[i];
//       }
//     }
//   return sumElements;
//   }


// int randomNumbers =  RandomNumbers(MassnumberElements, 0, 100);


// Console.WriteLine($"\nСумма элементов, находящихся на нечётных позициях: {randomNumbers}");





// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



// Console.Clear();

// float[] arrayNumbers = new float [10];               // инициализируем массив из 10 элементов, float тип для вещественных чисел с одинарной точностью (double - с двойной)
//  { 
//  Random random = new Random ();
//   for (int i = 0; i < arrayNumbers.Length; i++ )
//   {
//     arrayNumbers[i] = random.Next(1, 100);            // заполняем массив случайными числами в диапазоне min, max, для контроля значений при вызове мин/макс равны 1/100
//     Console.Write(arrayNumbers[i] + " ");
//   }
// }
// float maxNumber = arrayNumbers[0];
// float minNumber = arrayNumbers[0];


//   for (int i = 1; i < arrayNumbers.Length; i++)
//   {
//     if (maxNumber < arrayNumbers[i])
//     {
//       maxNumber = arrayNumbers[i];
//     }
//         if (minNumber > arrayNumbers[i])
//     {
//       minNumber = arrayNumbers[i];
//     }
//   }

//  float result = maxNumber - minNumber;


//   Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами равна {result}");







// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


// Console.Clear();

// Console.Write($"Введите число М (количество чисел): ");
// int m = Convert.ToInt32(Console.ReadLine());           //Ввод пользователем числа элементов массива M
// int[] massNumb = new int[m];

// void InputNumbers(int m)                               //Метод ввода пользователем M чисел поочередно
// {
// for (int i = 0; i < m; i++)
//   {
//     Console.Write($"Введите {i+1} число: ");
//     massNumb[i] = Convert.ToInt32(Console.ReadLine());  
//   }
// }


// int NumbLessZero(int[] massNumb)                     //метод сортировки элементов массива по условию, возврат счетчика полож-х чисел
// {
//   int count = 0;
//   for (int i = 0; i < massNumb.Length; i++)
//   {
//     if(massNumb[i] > 0 ) count += 1;             
//   }
//   return count;
// }

// InputNumbers(m);
// Console.WriteLine();
// Console.WriteLine($"Введено чисел больше 0: {NumbLessZero(massNumb)} ");










// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


// Console.Clear();
// double[,] coeff = new double[2, 2];
// double[] crossPoint = new double[2];


// void InputCoeff()                               // метод: считываем с консоли коэффициенты уравнения прямой
// {
//   for (int i = 0; i < coeff.GetLength(0); i++)
//   {
//     Console.Write($"Введите коэффициенты {i+1}-й прямой (y = k * x + b):\n");
//     for (int j = 0; j < coeff.GetLength(1); j++)
//     {
//       if(j==0) Console.Write($"Введите коэффициент k: ");
//       else Console.Write($"Введите коэффициент b: ");
//       coeff[i,j] = Convert.ToInt32(Console.ReadLine());
//     }
//   }
// }


// double[] CrossResult(double[,] coeff)               // метод: рассчитываем возможные точки пересечения прямых
// {
//   crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
//   crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
//   return crossPoint;
// }


// void CrossLines(double[,] coeff)                // метод: рассчитываем параллельность либо совпадение прямых по коэфф-м наклона и смещения
// {
//   if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
//   {
//     Console.Write($"\nПрямые совпадают");
//   }
//   else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
//   {
//     Console.Write($"\nПрямые параллельны");
//   }
//   else 
//   {
//     CrossResult(coeff);
//     Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
//   }
// }

// InputCoeff();
// CrossLines(coeff);



////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Seminar 7

// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



//  Console.Clear();
// 	Console.Write("Введите m: ");
// 	int m = Convert.ToInt32(Console.ReadLine());
// 	Console.Write("Введите n: ");
// 	int n = Convert.ToInt32(Console.ReadLine());


// 	Console.Clear();
// 	Console.WriteLine($"m = {m}, n = {n}.");


// 	double[,] array = new double[m, n];

// 	newArrayDouble(array);

// 	WriteArray(array);

// 	Console.WriteLine();


// 	void newArrayDouble(double[,] array)
// 	{
// 	  for (int i = 0; i < m; i++)
// 	  {
// 	    for (int j = 0; j < n; j++)
// 	    {
// 	      array[i, j] = new Random().NextDouble() * 20 - 10;
// 	    }
// 	  }
// 	}


// 	void WriteArray (double[,] array){
// 	for (int i = 0; i < m; i++)
// 	  {
// 	      for (int j = 0; j < n; j++)
// 	      {
// 	        double alignNumber = Math.Round(array[i, j], 1);   //округление значения до 1 знака после запятой 
// 	        Console.Write(alignNumber + "   ");
// 	      }
// 	      Console.WriteLine();
// 	  }
// 	}


//  ///////////////////////////////////////////////////////////////////////////////////////////

//  // Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//  // Например, задан массив:
//  // 1 4 7 2
//  // 5 9 2 3
//  // 8 4 2 4
//  // 17 -> такого числа в массиве нет

// 

////////////////////////////////////////////////////////////////////

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
int m= arr.GetLength(0);
int n= arr.GetLength(1);
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("---------------------------");
Console.WriteLine(m + "  строк ");
Console.WriteLine(n + "  столбцов ");

Console.Write($"\nCреднее арифметическое:\n");
 for (int i = 0; i < m; i++)
 {
   double midArithmMean = 0;   
   for (int j = 0; j < n; j++)
   {
     midArithmMean += arr[i, j];
   }
   midArithmMean = Math.Round(midArithmMean / m, 1);  //округление до 1 знака после запятой значения ср.арифметического
   Console.WriteLine($"столбца № {i+1}:  {midArithmMean}");
 }


