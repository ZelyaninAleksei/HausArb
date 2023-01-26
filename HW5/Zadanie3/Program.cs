// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Randomizer(int[] massiv, int size)
{
    Random rnd = new Random();
    for (int i = 0; i <= size - 1; i++)
    {
        massiv[i] = rnd.Next(0, 100);
        // System.Console.WriteLine($"------> {massiv[i]}");
    }
}

int Itog(int[] massiv, int size)
{
    int max = massiv[0];
    int min = massiv[0];
    for (int i = 0; i <= size - 1; i++)
    {
        if (max < massiv[i])
        {
            max = massiv[i];
        }
        else if (min > massiv[i])
        {
            min = massiv[i];
        }
        else
        {
        }
    }
    int itog = max - min;
    return itog;
}

int size = 5;
int[] massiv = new int[size];
Randomizer(massiv, size);
int result = Itog(massiv, size);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива составляет {result}");
