// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int EnterNum(string number)
{
    System.Console.WriteLine(number);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int FindSizeNumber(int number)
{
    int result = (int)Math.Log10(number) + 1;
    return result;
}

int GetDigit(int number, int counter)
{
    int x = (int)(number / Math.Pow(10, counter - 1)) % 10;
    return x;
}

int FindSumNum(int number, int sizeNum)
{
    int sum = 0;
    for (int i = 1; i <= sizeNum; i++)
    {
        sum = sum + GetDigit(number, i);
    }
    return sum;
}

int number = EnterNum("Введите число =>");
int sizeNum = FindSizeNumber(number);
int sum = FindSumNum(number, sizeNum);

Console.WriteLine($"Сумма цифр в числе {number} составляет {sum}");
