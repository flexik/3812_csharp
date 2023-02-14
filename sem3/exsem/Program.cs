
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

// // СЕМИНАР №3
// using System;

// Console.Write("Введите номер четверти: ");
// int X = int.Parse(Console.ReadLine());

// if(X==1)
// {
//     Console.WriteLine("x>0 и y>0");
// }
// if(X==2)
// {
//     Console.WriteLine("x<0 и y>0");
// }
// if(X==3)
// {
//     Console.WriteLine("x<0 и y<0");
// }
// if(X==4)
// {
//     Console.WriteLine("x>0 и y<0");
// }
// if (X <= 0 || X > 4)
//     Console.WriteLine("Такой четверти не существует");


// ____________


// using System;

// Console.WriteLine("Введите x1: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите x2: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите y2: ");
// int y2 = int.Parse(Console.ReadLine());

// double s = Math.Sqrt(Math.Pow((x1-x2),2)+ Math.Pow((y1-y2),2));
// Console.Write($"Расстояние между точками: {s}");


// прога принимает на вход число N и выдает таблицу квадратов чисел от 1 до N


// Console.Clear();
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());
// int i = 1;
// int m = N; // m = -10
// if (N < 0)
// {
// i = N; //i = -10
// m = -N;// m = 10
// N = -1; // N = N * (-1) N = -1


// }
// int[] result = new int[m];
// int j = 0;
// for (; i <= N; i++)
// {
// result[j] = i * i;
// j++;
// }
// for ( j = 0; j < m; j++)
// {
// Console.Write($"{result[j]} ");
// }
