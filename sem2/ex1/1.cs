// Семинар №2

// 1) Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 - найти случайное число + разбить число на цифры + сравнить их и вывести большее
// 12-> 2
// 85 -> 8

using System;

Console.Clear();

int num = new Random().Next(10, 100);
Console.WriteLine($"MAX = {num}");

int num1 = num/10;
int num2 = num%10;
int max = num2;

if (num1 > max){
    max = num1;
}
Console.WriteLine($"MAX = {max}");