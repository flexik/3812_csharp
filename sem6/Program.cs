// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// Console.Clear();

// int[] Array1 = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(", ", Array1));

// int[] GetArray(int size, int min, int max)    // метод возвращающий заданный массив
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max + 1);
//     }
//     return result;
// }

// int[] ArrayConverse(int[] arr){              // метод возвращающий перевернутый массив
//     int[] result = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         result[i] = arr[arr.Length - i - 1];
//     }
//     return result;
// }

// int[] conversedArray = ArrayConverse(Array1);
// Console.WriteLine(String.Join(", ", conversedArray));


/*______________________________________________________________________*/

// **Задача 40:**Напишите программу,
// которая принимает на вход три числа и проверяет, может ли
// существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.
// Console.WriteLine("Введите стороны треугольника через пробел: ");

// string[] st = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

// int a = Int32.Parse(st[0]);
// int b = Int32.Parse(st[1]);
// int c = Int32.Parse(st[2]);

// bool IsTriangle(int a, int b, int c)                 // ф-ия возвращающая true или false
// {
//     return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
// }

// if (IsTriangle(a, b, c))       // если функция вернет true от наших 3 чисел, то - да, если false то - нет 
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

//____________________________________________________________//

// **Задача 42:**Напишите программу,
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

//Универсальный перевод в двоичную систему из любой
// string DecToNum(int decNumber, int otherSystem)
// {
// string res = "";
// string nums = "0123456789ABCDEF";
// while (decNumber > 0)
// {
// int ost = decNumber / otherSystem;
// res = nums[decNumber - otherSystem * ost] + res;
// decNumber /= otherSystem;
// }
// return res;
// }

/*Задача 45: Напишите программу,
которая будет создавать копию заданного массива с помощью поэлементного копирования.*/
