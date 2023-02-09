// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateArray()
{
    int[,] baseArray = new int[5, 5];
    Random rnd = new Random();
    for (int i = 0; i < baseArray.GetLength(0); i++)
    {
        for (int j = 0; j < baseArray.GetLength(1); j++)
        {
            baseArray[i, j] = rnd.Next(1, 9);
        }
    }
    return baseArray;
}

int[] ArrayStringValues(int[,] baseArray)
{
    int[] arrayValues = new int[baseArray.GetLength(0)];
    for (int i = 0; i < baseArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < baseArray.GetLength(1); j++)
        {
            sum = sum + baseArray[i, j];
        }
        arrayValues[i] = Convert.ToInt32(sum);
    }
    return arrayValues;
}

void PrintDuoArray(int[,] arrayNumbers)
{
    Console.WriteLine("Значение элементов массива:");
    for (int i = 0; i < arrayNumbers.GetLength(0); i++)
    {
        Console.WriteLine(" ");
        for (int j = 0; j < arrayNumbers.GetLength(1); j++)
        {
            Console.Write($"{arrayNumbers[i, j]}   ");
        }
    }
    Console.WriteLine(" ");
}

void PrintOneArray(int[] arrayNumbers)
{
    Console.WriteLine("Значение сумм построчно:");
    for (int i = 0; i < arrayNumbers.GetLength(0); i++)
    {
        Console.Write($"{arrayNumbers[i]}   ");
    }
    Console.WriteLine(" ");
}

void SearchSmallestSum(int[] baseArray)
{
    int minIndex = 0;
    for (int j = 0; j < baseArray.Length - 1; j++)
    {

        if (baseArray[minIndex] > baseArray[j + 1])
        {
            minIndex = j + 1;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: = {minIndex+1} индекс = {minIndex}");
}


int[,] baseArray = CreateArray();
int[] strValue = ArrayStringValues(baseArray);
Console.WriteLine("==========");
PrintDuoArray(baseArray);
Console.WriteLine("==========");
PrintOneArray(strValue);
SearchSmallestSum(strValue);
