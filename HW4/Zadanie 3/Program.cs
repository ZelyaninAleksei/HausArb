// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/


void Completion(int[] newnums, int size)
{
    Random rnd = new Random();
    for (int i = 0; i <= size - 1; i++)
    {
        newnums[i] = rnd.Next(0, 10);
    }
}

void Conclusion(int[] newnums, int size)
{
    for (int i = 0; i <= size - 1; i++)
    {

        System.Console.Write(newnums[i]);

    }
}

int size = 8;
int[] newnums = new int[size];
Completion(newnums, size);
Conclusion(newnums, size);