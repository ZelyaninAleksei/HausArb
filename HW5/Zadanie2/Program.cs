// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



void Randomizer(int[] mymassiv, int size)
{
    Random rnd = new Random();
    for (int i = 0; i <= size; i++)
    {
        mymassiv[i] = rnd.Next(-100, 100);
    }
}

int Sum(int[] mymassiv, int size)
{
    int suma = 0;
    for (int i = 0; i <= size; i++)
    {
        if (i % 2 != 0)
        {
            suma = suma + mymassiv[i];
        }
    }
    return suma;
};

void PrintMassiv(int[] mymassiv, int size)
{
    for (int i = 0; i <= size -1; i++)
    {
        System.Console.WriteLine($" Элекмент массива -> {mymassiv[i]}");
    }
}

int size = 4;
int[] mymassiv = new int[size];
Randomizer(mymassiv, size - 1);
int itog = Sum(mymassiv, size - 1);
PrintMassiv(mymassiv,size);
System.Console.WriteLine($" Сумма элементов стоящих на нечётных позициях в массиве равна -> {itog}");