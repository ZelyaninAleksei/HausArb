// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



void Randomizer(int[,] arrayNumbers)
{
    for (int i = 0; i < arrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumbers.GetLength(1); j++)
        {
            Random rnd = new Random();
            arrayNumbers[i, j] = rnd.Next(1, 100);
        }
    }
}

int UserInputPosition(int[,] arrayNumbers, string message)
{
    Console.WriteLine($"Введите номер {message}-> ");
    int positiont = Convert.ToInt32(Console.ReadLine());
    return positiont - 1;
}

void FindElement(int[,] arrayNumbers, int positiontinLine, int positiontinСolumn)
{

    if (positiontinLine > (arrayNumbers.GetLength(0) -1)|| positiontinСolumn > (arrayNumbers.GetLength(1) -1))
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine(arrayNumbers[positiontinLine, positiontinСolumn]);
    }
}

void PrintArray(int[,] arrayNumbers)
{
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

int[,] arrayNumbers = new int[3, 4];
Randomizer(arrayNumbers);
PrintArray(arrayNumbers);
int positiontinLine = UserInputPosition(arrayNumbers, "строки");
int positiontinСolumn = UserInputPosition(arrayNumbers, "столбца");

FindElement(arrayNumbers, positiontinLine, positiontinСolumn);
