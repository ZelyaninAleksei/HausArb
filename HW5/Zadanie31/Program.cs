// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Randomizer(double[] massiv, int size)
{
    Random rnd = new Random();
    for (int i = 0; i <= size - 1; i++)
    {
        massiv[i] = rnd.NextDouble()*20;
        // System.Console.WriteLine($"------> {massiv[i]}");
    }
}

double Itog(double[] massiv, int size)
{
    double max = massiv[0];
    double min = massiv[0];
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
    double itog = max - min;
    return itog;
}

int size = 5;
double[] massiv = new double[size];
Randomizer(massiv, size);
double result = Itog(massiv, size);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива составляет {result}");
