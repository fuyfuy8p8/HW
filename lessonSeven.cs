
// // // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// // Console.WriteLine("Введите кол-во строк");
// // int rows = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Введите кол-во столбцов");
// // int columns = Convert.ToInt32(Console.ReadLine());

// // double[,] matrix = new double[rows, columns];

// // for (int i = 0; i < matrix.GetLength(0); i++)
// // {
// //     for (int j = 0; j < matrix.GetLength(1); j++)
// //     {
// //        matrix[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
// //        Console.Write(matrix[i,j]+"   "); 
// //     }
// //     Console.WriteLine();
// // }

// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Например, задан массив:


// Console.WriteLine("Введите кол-во строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// FillArrayRandomNumbers(numbers);
// if (n>numbers.GetLength(0) || m>numbers.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {n} строки и {m} столбца равно (numbers[n-1,m-1])");
// }

// PrintArray(numbers);
// void FillArrayRandomNumbers(int[,]array)
// {
//     for (int i = 0; i < array.Getlength(0); i++)
//     {
//         for (int j = 0; j < array.Getlength(1); j++)
//         {
//             array[i,j] = new random().Next(-100,100)/10;
//         }
//     }  
    
// }


// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


// Console.WriteLine("Введите кол-во строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] = new int[n,m];

// FillArrayRandomNumbers(number);

// for (int j = 0; j < numbers.Getlength(1); j++)

// {
//     double srZnach = 0;
//     for (int i = 0; i < numbers.Getlength(0); i++)
//     {
//         srZnach += numbers[i,j];

//     }
//     srZnach/=n;
//     Console.Write(srZnach+"; ")
// }

// Console.WriteLine();
// PrintArray(numbers);

// void FillArrayRandomNumbers(int[,]array)
// {
//     for (int i = 0; i < numbers.Getlength(0); i++)
//     {
//         for (int j = 0; j < numbers.Getlength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10);
//         }
//     }
    
// }


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.getlength(0); i++)
//     {
//         for (int j = 0; j < array.getlength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         console.WriteLine();
//     }
// }


