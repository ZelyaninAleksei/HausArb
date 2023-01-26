// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



void Randomizer(int[] mymassiv, int size)
{
    Random rnd = new Random();
    for (int i = 0; i <= size; i++)
    {
        mymassiv[i] = rnd.Next(0, 50);
    }
}

int Sum(int[] mymassiv, int size)
{
    int suma = 0;
    for (int i = 0; i <= size; i++)
    {
        if (i % 2 != 0)
        {
            int a2 = suma;
            a2 = a2 + mymassiv[i];
            suma = a2;
        }
    }
    return suma;
};

int size = 40;
int[] mymassiv = new int[size];
Randomizer(mymassiv, size - 1);
int itog = Sum(mymassiv, size - 1);
System.Console.WriteLine($" Сумма элементов стоящих на нечётных позициях в массиве равна {itog}");