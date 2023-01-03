// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int []array = new int[7];
// int count = 0;

// for(i=0;i<array.lenght;i++)
// {
//     array[i]= new Random().Next(100,1000);
//     if (array[i]%2==0)
//     {
//         count++;
//     }
// }
// Console.Writeline(string.Join(",",array));
// console.Writeline(count);


// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int []array = new int[5];
// int sum = 0;

// for(i=0;i<array.lenght;i++)
// {
//     array[i]= new Random().Next(-99,100);
//     if (array[i]%2==1)
//     {
//         sum+=array[i];
//     }
// }
// Console.Writeline(string.Join(",",array));
// console.Writeline(sum);


// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// int n = convert.ToInt32(console.Readline());
// int [] array =new int[n];

// int max = int.MinValue;
// int min = int.MaxValue;


// for(i=0;i<array.lenght;i++)
// {
//     array[i]= new Random().Next(int.MinValue,int.MaxValue);
//     if (array[i]>max)
//     {
//         max=array[i];
//     }
//     if (array[i]<min)
//     {
//         min=array[i];
//     }
// }
// Console.Writeline(string.Join(",",array));
// console.Writeline(max-min);
