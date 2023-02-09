// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArray()
{
    int[,] baseArray = new int[2, 2];
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

void PrintMatrix (int[,] arrayNumbers, string message)
{
    Console.WriteLine(message);
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

int[,] MatrixTotal(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] total = new int[2, 2];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            total[i, j] = firstMatrix[i, j] * secondMatrix[j, i];
        }
    }
    return total;
}


int[,] firstMatrix = CreateArray();
int[,] secondMatrix = CreateArray();
int[,] totalMatrix = MatrixTotal(firstMatrix, secondMatrix);

PrintMatrix(firstMatrix, "Первая матрица:");
PrintMatrix(secondMatrix, "Вторая матрица:");
PrintMatrix(totalMatrix, "Итоговая:");