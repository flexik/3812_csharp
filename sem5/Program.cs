//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].    getArray (12, -9, 9)
//Найдите сумму отрицательных и положительных элементов массива.

// Console.Clear();

// int[] GetArray(int size, int min, int max){
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max + 1);

//     }
//     return result;

// }

// int[] Array = GetArray(12, -9, 9);
// Console.WriteLine(String.Join(" ", Array));

// int positiveSum = 0;
// int negativeSum = 0;

// foreach (int el in Array)
// {
//     positiveSum += el > 0 ? el : 0;
//     negativeSum += el < 0 ? el : 0;
// }

// Console.WriteLine(positiveSum);
// Console.WriteLine(negativeSum);


// **Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Console.Clear();

// int[] GetArray(int size, int min, int max){
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max + 1);

//     }
//     return result;

// }

// int[] Array1 = GetArray(12, -9, 9);
// Console.WriteLine(String.Join(", ", Array1));

// int[] InversArray(int[] Array){
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Array[i] *= -1;
//     }
//     return Array;
// }

// Console.WriteLine(String.Join(", ", InversArray(Array1)));

// **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// Console.Clear();
// Console.Write("Введите элементы массива через пробел: ");
// string elements = Console.ReadLine();
// int[] baseArray = GetArrayFromString(elements);
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// if (FindElement(baseArray, n))
// {
// Console.WriteLine("Да");
// }
// else
// {
// Console.WriteLine("Нет");
// }


// int[] GetArrayFromString(string stringArray)
// {
// string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[] res = new int[nums.Length];

// for (int i = 0; i < nums.Length; i++)
// {
// res[i] = int.Parse(nums[i]);
// }
// return res;
// }

// bool FindElement(int[] array, int el)//[1,2,3,4] 5
// {
// foreach (var item in array)//
// {
// if (el == item) // 5 == 4
// return true;
// }
// return false;
// }