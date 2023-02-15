// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

void SummationOfNaturalNumbers(int firstNumber, int secondNumber, int sum)
{
    if (firstNumber > secondNumber)
    {
        Console.Write($"{sum}");
        return;
    }

    sum = sum + (firstNumber++);
    SummationOfNaturalNumbers(firstNumber, secondNumber, sum);
}


int firstNumber = Prompt("Введите стартовое число M ->");
int secondNumber = Prompt("Введите конечное число N ->");


Console.Write($"Сумма натуральных элементов в промежутке от {firstNumber} до {secondNumber} = ");
SummationOfNaturalNumbers(firstNumber, secondNumber, 0);