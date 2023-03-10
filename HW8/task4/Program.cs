// Задача * 4. Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] total = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= total.GetLength(0) * total.GetLength(1))
{
    total[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < total.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= total.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > total.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(total);

