// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Randomizer(int[,] arrayNumbers)
{
    Random rnd = new Random();
    for (int i = 0; i < arrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumbers.GetLength(1); j++)
        {
            arrayNumbers[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintArray(int[,] arrayNumbers)
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

void PrintAverage(int[,] arrayNumbers)
{
    for (int j = 0; j < arrayNumbers.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arrayNumbers.GetLength(0); i++)
        {
            sum += Convert.ToDouble(arrayNumbers[i, j]);
        }

        Console.WriteLine($"Среднее арифмитическое столбца № {j} -> {Math.Round(sum / arrayNumbers.GetLength(0), 2)}");
    }
}


int[,] arrayNumbers = new int[3, 4];
Randomizer(arrayNumbers);
PrintArray(arrayNumbers);
PrintAverage(arrayNumbers);

