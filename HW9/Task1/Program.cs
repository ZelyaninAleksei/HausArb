// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

void ShowNumbers(int startNumber, int finishNumber)
{
    if (startNumber >= finishNumber)
    {
        return;
    }
    if (startNumber % 2 != 0)
    {
        startNumber++;
    }
    Console.Write($"{startNumber} ");
    ShowNumbers(startNumber + 1, finishNumber);
}

int startNumber = Prompt("Введите стартовое число ->");
int finishNumber = Prompt("Введите конечное число ->");

Console.Write($" В отрезке между введённым числами {startNumber} и {finishNumber} находятся следующие чётные натуральные числа: ");
ShowNumbers(startNumber, finishNumber);
