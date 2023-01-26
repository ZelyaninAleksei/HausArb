//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите первое число ->");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ->");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ->");
int endNum = Convert.ToInt32(Console.ReadLine());

int maxNum = firstNum;
if (maxNum < secondNum) {
    maxNum = secondNum;
}
if (maxNum < endNum) {
    maxNum = endNum;
}

Console.WriteLine($"Максимальное число {maxNum}");