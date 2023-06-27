﻿/*
Задача 29: Напишите программу, которая задаёт
 массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void FillArray(int[] collection){

    int length = collection.Length;
    int index = 0;
    while(index<length){
        collection[index] = new Random().Next(1, 100);
        index ++;
    }
    Console.WriteLine($"[{string.Join(", ", collection)}]");
}

int[] arr = new int[8];
FillArray(arr);