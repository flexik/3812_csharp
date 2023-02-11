// является ли число палиндромом

// Console.Clear();
// Console.Write("Введите число : ");
// int num = int.Parse(Console.ReadLine());//num = 12345
// int a1 = num / 10000; // num / 10000 = 1
// num = num - (a1 * 10000); // 12345 - (1 * 10000) = 2345 <=> num = num % 10000 (2345)
// int a2 = num / 1000; // 2345 / 1000 = 2
// num -= a2 * 1000; // num = 345
// int a3 = num / 100; // 345 / 100 = 3
// num -= a3 * 100; // num = 45
// int a4 = num / 10; // a4 = 45 / 10 = 4
// int a5 = num % 10; // a5 = 5 = 45 % 5
// if (a1 == a5 && a2 == a4)
// {
// Console.Write("Да");
// }
// else
// {
// Console.Write("Нет");
// }


// прога принимает на вход число A и выдает сумму чисел от 1 до A

// Console.Clear();
// Console.Write("Введите число : ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine($"Сумма от 1 до {n} равна {GetSum(n)}");

// int GetSum(int limit){
//     int sum = 0;
//     for (int i = 1; i <= limit; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }


// Напишите прогу которая принимает число и выдает кол-во цифр в числе
// 456 - 3
// 78 - 2
// 89126 - 5

// Console.Clear();
// Console.Write("Введите число : ");
// int n = int.Parse(Console.ReadLine());

// int CharQty(int number){
//     if (number < 0){
//         number *= -1;
//     }
//     int kol = 0;
//     while (number > 0)
//     {
//         number /= 10;
//         kol ++;
//     }
//     return kol;
// }

// Console.WriteLine($"Количество цифр в числе равно {CharQty(n)}");


// Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4-> 24
// 5-> 120 == 1 * 2 * 3 * 4 * 5

// Console.Clear();
// Console.Write("Введите число : ");
// int n = int.Parse(Console.ReadLine());

// int Proizvedenie(int limit){
//     int result = 1;
//     for (int i = 2; i <= limit; i++)
//     {
//         result = result * i;
//     }
//     return result;
// }

// Console.WriteLine($"произведение чисел от 1 до {n} равно {Proizvedenie(n)}");





//30 Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.

// Console.Clear();
// Console.Write("Введите число: ");
// int num = 8;
// int[] array = GetBinArray(num);
// Console.Write($"[{String.Join(", ", array)}]");
// Console.Write($"[");
// for (int i = 0; i < num - 1; i++){
//     Console.Write($"{array[i]}, ");
// }Console.Write($"{array[num - 1]}]");


// int[] GetBinArray(int size){
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++){
//         result[i] = new Random().Next(2);
//     }
//     return result;
// }
