/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.Clear();
Console.WriteLine("Введите числа через пробел");
 
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);
PrintArray(array);

Console.WriteLine("Сумма элементов на нечетных позициях: " + OddNumbersSum(array));

  
  
int[] ParseToArray(string str)
{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];
 
    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
 
    return result;
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
 
int OddNumbersSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum += array[i];
    }
 
    return sum;
}