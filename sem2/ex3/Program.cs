// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


// using System;

// Console.Clear();

// Console.WriteLine("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());

// if (num1%num2 == 0){
//     Console.WriteLine("Второе число кратно первому");
// }else{
//     Console.WriteLine($"Второе число не кратно первому, остаток : {num1%num2}");
// }



// **Задача 14:**
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// using System;

// Console.Clear();

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// if (num % 7 == 0 && num % 23 == 0)
// // 161 % 7 == 0 * 161 % 23 == 0
// // 1 * 1 = 1
// {
// Console.WriteLine("Да");
// }else{
// Console.WriteLine("Нет");
// }

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// using System;

// Console.Clear();

// Console.WriteLine("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());

// if (num1 == Math.Pow(num2, 2) || num2 == Math.Pow(num1, 2))
// {
//     Console.WriteLine("Да");
// }else{
//     Console.WriteLine("Нет");
// }

