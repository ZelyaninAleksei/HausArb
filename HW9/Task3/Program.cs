// Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int EnterUserNumber(string message)
{
    Console.WriteLine($"Введите целое число для параметра {message}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
       return Akkerman(m - 1, 1);
    }
    else
    {
      return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

//1. Ввести параметры М и Н
int m = EnterUserNumber("m");
int n = EnterUserNumber("n");

//2. Рассчитать с введёнными аргументами функцию Аккермана
int result = Akkerman(m, n);

//3. Вывести результат
System.Console.WriteLine($"Результат функции Аккермана -> {result}");