/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int length = int.Parse(Console.ReadLine()!);
int[] array = CreateArray(length);
PrintArray(array);
Console.WriteLine("Количество четных элементов в массиве: " + EvenNumbersCount(array));



int[] CreateArray(int len)
{
    int[] arr = new int[len];
    Random rand = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rand.Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(arr[i]);
        if (i == count - 1)            
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
    Console.WriteLine();
}

int EvenNumbersCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0)
            count++;
    }
    return count;
}