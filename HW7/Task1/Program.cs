// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Randomizer(double[,] baseArray)
{
    for (int i = 0; i < baseArray.GetLength(0); i++)
    {
        for (int j = 0; j < baseArray.GetLength(1); j++)
        {
            Random rnd = new Random();
            baseArray[i, j] = -10 + rnd.NextDouble() * (10 + 10);
        }
    }
}

void PrintArray(double[,] baseArray)
{
    for (int i = 0; i < baseArray.GetLength(0); i++)
    {
        Console.WriteLine(" ");
        for (int j = 0; j < baseArray.GetLength(1); j++)
        {
            Console.Write(String.Format($"{baseArray[i, j]:F2}; | "));
        }
    }
}


double[,] baseArray = new double[3, 4];
Randomizer(baseArray);
PrintArray(baseArray);