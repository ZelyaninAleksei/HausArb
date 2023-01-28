// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreatArray(string message) //Функция создания массива c заданным пользователем размером
{
    System.Console.WriteLine(message + "-->");
    int sizeMassiv = Convert.ToInt32(Console.ReadLine());
    int[] massiv = new int[sizeMassiv];
    return massiv;
}

int[] FillingArray(int[] baseArray, string message) //Функция заполнения массива пользователем
{
    for (int i = 0; i < baseArray.Length; i++)
    {
        System.Console.WriteLine(message + $" {i}-->");
        baseArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return baseArray;
}

void DisplayElements(int[] baseArray) //Процедура вывода индекса и присвоенного элемента (для проверки)
{
    System.Console.WriteLine("Введённые элементы массива:");
    for (int i = 0; i < baseArray.Length; i++)
    {
        System.Console.WriteLine($" {i + 1}) Индекс массива = {i} элемент = {baseArray[i]}");
    }
}

void FindNum(int[] baseArray) //Процедура проверки условия таска и вывод результата
{
    int count = 0;
    for (int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i] > 0)
        {
            count++;
        }
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine($"Количество элементов массива со значением больше нуля составляет --> {count}");
    Console.ResetColor();
}



int[] baseArray = CreatArray("Введите размер массива");
string message = $"Введите значение элемента с индексом №";
FillingArray(baseArray, message);
DisplayElements(baseArray);
FindNum(baseArray);
