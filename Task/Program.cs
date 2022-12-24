// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;
using static System.Console;

Clear();
Write("Введите размер основного массива: ");
int n = int.Parse(ReadLine());
Write("Задайте максимальный размер элементов нового массива: ");
int m = int.Parse(ReadLine());

string[] baseArray = GetArray(n);
WriteLine($"Основной массив: {String.Join(" ", baseArray)}");

Write("Результат: ");
FilteredArray(baseArray, m);

string[] GetArray(int length)  //генерируем основной массив
{
    string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    string[] result = new string[length];
    for (int i = 0; i < length; i++)
    {
        string item = string.Empty;
        for (int itemLength = 0; itemLength <= new Random().Next(0, m * 3); itemLength++)
        {
            item += chars[new Random().Next(chars.Length)];
        }
        result[i] = item;
    }
    return result;
}

void FilteredArray(string[] baseArray, int m)
{
    int count = 0;
    foreach (string item in baseArray)
    {
        if (item.Length <= m)
        {
            Write($"{item} ");
            count++;
        }
    }
    if (count == 0){
        Write("Нет элементов соответствующих условию");
    }
}