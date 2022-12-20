// // задача 2. Найти большее число из двух вводимых
// Console.WriteLine("Введите число 1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int max = 0;

// if (num1 > num2)
//     {
//        max= num1;
//     }
// else
//     {
//         max=num2;
//     }
// Console.WriteLine("Максимальное число " + max);


// // Задача 4. Три числа на вход. на выходе максимальное
// Console.WriteLine("Введите число 1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 3");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = 0;

// if (num1 > num2&&num1>num3)
//     {
//        max= num1;
//     }
// else if (num2 > num1&&num2>num3)
//     {
//         max=num2;
//     }
//  else if (num3 > num2&&num3>num1)
//     {
//         max=num3;
//     }
// Console.WriteLine("Максимальное число " + max);


// // Задача 6. программа даёт число на вход. Определить является ли оно чётным

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1%2!=0)
//     {
//         Console.WriteLine("Нет");
//     }
// else
//     {
//         Console.WriteLine("Да");
//     }

// // Задача 8. программа принимает N, а на выходе показывает все чётные числа до N

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// while (num1>0)
//     {
//         if (num1%2!=0)
//             {
//                 Console.WriteLine(num1);
//                 num1-=2; 
//             }   
//         else
//             {
//                 Console.WriteLine(num1-1);
//                 num1-=2;
//             }   
//     }