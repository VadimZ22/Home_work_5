/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int length = int.Parse(Console.ReadLine()!);
double[] array = CreateArray(length);
Console.WriteLine(String.Join(", ", array));
double difference = GetDifference(array);
Console.WriteLine("Разница между максимальным и минимальным элементов массива: " +  difference);



double[] CreateArray(int len)
{
    double[] arr = new double[len];
    Random rand = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = Math.Round(rand.NextDouble(), 2);
    }
    return arr;
}

double GetDifference (double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    double result = (max - min);
    return result;
}




