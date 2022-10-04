/*Найти в массиве самую длинную последовательность, 
состоящую из одинаковых элементов. Вывести на экран количество элементов самой длиной последовательности, 
элемент самой последовательности и номер элемента, который является ее началом.*/

Console.Clear();

int[] array = {1, 0, 1, 1, 1, 1, 1, 0, 1, 1};

int count = 0;
int tempCount = 0;
int index = 0;
int tempIndex = 0;
int number = array[0];
int tempNumber = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == tempNumber)
    {
        tempCount++;
    }
    else
    {
        if (tempCount > count)
        {
            count = tempCount;
            number = tempNumber;
            index = tempIndex;
        }
        tempNumber = array[i];
        tempCount = 1;
        tempIndex = i;
    }
}

Console.WriteLine(count);
Console.WriteLine(number);
Console.WriteLine(index);

