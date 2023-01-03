
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
























// //  Задача 53: Задайте двумерный массив. Напишите программу, которая 
// // поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите количество строчек");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());



// int [,] GetArray()
// {
//     int[,] result= new int [rows,columns];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i,j] = new Random().Next(10);
//         }
//     }
//     return result;
// }
// int [,] ChageRows(int[,] result)
// {
//     int  change=0;
//     int rowsCount= result.GetLength(0)-1;
//     for (int i = 0; i <result.GetLength(0); i++)
//     {
//         change = result[0,i];
//         result[0,i]= result[rowsCount,i];
//         result[rowsCount,i]=change;
//     }
//     return result;
// }
// void PrintArray(int[,] result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Console.Write(result[i,j]);
            
//         }
//         Console.WriteLine();
//     }
// }
// int [,] matrix= GetArray();
// PrintArray(matrix);

// Console.WriteLine();

// PrintArray(ChageRows(matrix));



// Задача 55: Задайте двумерный массив. Напишите программу,
//  которая заменяет строки на столбцы. В случае, если это 
//  невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите количество строчек");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows!=columns)
{
    Console.WriteLine("Массив не подходит");
    return;
}

int [,] GetArray()
{
    int[,] result= new int 
int [,] ChangeArray(int[,] result)
    {
        int [,] array_2= new int[result.GetLength(0),result.GetLength(1)];
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                array_2[j,i] = result[i,j];
            }
        }
        return array_2;
    }
}
void PrintArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write(result[i,j]);
            
        }
        Console.WriteLine();
    }
}
int [,] matrix= GetArray();
PrintArray(matrix);

Console.WriteLine();

PrintArray(ChangeArray(matrix));



// // Задача 59: Задайте двумерный массив из целых чисел.
// //  Напишите программу, которая удалит строку и столбец
// //  , на пересечении которых расположен наименьший элемент массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Наименьший элемент - 1, на выходе получим 
// // следующий массив:

// Console.WriteLine("Введите количество строчек");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int minValue=int.MaxValue;
// int minIndexRows=0;
// int minIndexCol=0;
// int [,] GetArray()
// {
//     int[,] result= new int [rows,columns];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i,j] = new Random().Next(10);
//             if ( result[i,j]<minValue)
//             {
//                 minValue= result[i,j];
//                 int minIndexRows=i;
//                 int minIndexCol=j;
//             }
//         }
//     }
//     return result;
// }
// void n(int[,] result)
// {
    
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         if (i!=minIndexRows)
//         {
//             for (int j = 0; j < result.GetLength(1); j++)
//             {
//                 if (j!=minIndexCol)
//                 {
//                      Console.Write(result[i,j]+"\t");

//                 }
                
//             }
//             Console.WriteLine();
//         }
        
//     }
    
// }
// void PrintArray(int[,] result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Console.Write(result[i,j]);
            
//         }
//         Console.WriteLine();
//     }
// }
// int [,] matrix= GetArray();
// PrintArray(matrix);

// Console.WriteLine();

// n(matrix);
// / Задача 59: Задайте 
// int [,] GetArray()
// {
//     int[,] result= new int [rows,columns];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i,j] = new Random().Next(10);
//             if ( result[i,j]<minValue)
//             {
//                 minValue= result[i,j];
//                minIndexRows=i;
//                minIndexCol=j;
//             }
//         }
//     }
//     return result;
// }
// void n(int[,] result)
// {
//     Console.WriteLine(minIndexRows+" "+minIndexCol);
    
 
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         if (i!=minIndexRows)
//         {
// От Вадим всем 08:11 PM
// void PrintArray(int[,] result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Console.Write(result[i,j]);
            
//         }
//         Console.WriteLine();
//     }
// }
// int [,] matrix= GetArray();
// PrintArray(matrix);

// Console.WriteLine();

// n(matrix);
