// //  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] BaseArray()
{
    int[,] baseArray = new int[3, 4];
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

void SortingArray(int[,] baseArray)
{
    int temp = 0;
    for (int i = 0; i < baseArray.GetLength(0); i++)
    {
        for (int j = 0; j < (baseArray.GetLength(1)); j++)
        {
            for (int k = 0; k < baseArray.GetLength(1) - 1; k++)
            {

                if (baseArray[i, k] < baseArray[i, k + 1])
                {
                    temp = baseArray[i, k + 1];
                    baseArray[i, k + 1] = baseArray[i, k];
                    baseArray[i, k] = temp;
                }
            }
        }
    }
}
void PrintSortedArray(int[,] baseArray, string message)
{
    System.Console.WriteLine($"{message} ");
    for (int i = 0; i < baseArray.GetLength(0); i++)
    {
        for (int j = 0; j < baseArray.GetLength(1); j++)
        {
            System.Console.Write($"{baseArray[i, j]}   ");
        }
        System.Console.WriteLine(" ");
    }
}

//1. Создать двумерный массив
//2. Заполнить созданный массив
int[,] baseArray = BaseArray();

//3. Создать цикл сравнения элементов массива между собой и вслучае необходимости смена позиции
PrintSortedArray(baseArray, "Созданный массив:");
SortingArray(baseArray);

//4. Вывод результата 
PrintSortedArray(baseArray, "Отсортированный массив:");
