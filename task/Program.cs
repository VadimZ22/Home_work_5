/*Найти в массиве самую длинную последовательность, 
состоящую из одинаковых элементов. Вывести на экран количество элементов самой длиной последовательности, 
элемент самой последовательности и номер элемента, который является ее началом.*/

Console.Clear();

int[] array = {1, 0, 1, 1, 1, 1, 1, 0, 1, 1};
int counter = 0;
int element = 0;
int position = 0;


GetInfo(array, out counter, out element, out position);
Console.WriteLine(counter);
Console.WriteLine(element);
Console.WriteLine(position);


void GetInfo(int[] array, out int count, out int number, out int index)
{
    count = 0;
    int tempCount = 0;
    index = 0;
    int tempIndex = 0;
    number = array[0];
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
}


