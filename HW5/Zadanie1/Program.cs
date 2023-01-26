// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Randomizer(int[] mymassiv, int size)
{
    Random rnd = new Random();
    for (int i = 0; i <= size; i++)
    {
        mymassiv[i] = rnd.Next(100, 999);
    }
}

int Sum(int[] mymassiv, int size)
{
    int count = 0;
    for (int i = 0; i <= size; i++)
    {
        if (mymassiv[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
};

int size = 4;
int[] mymassiv = new int[size];
Randomizer(mymassiv, size - 1);
int itog = Sum(mymassiv, size - 1);
System.Console.WriteLine($" Rоличество чётных чисел в массиве - {itog}");