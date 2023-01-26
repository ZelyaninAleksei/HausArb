// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
/*14212 -> нет
23432 -> да
12821 -> да
*/

//ВАРИАНТ 2 (На принятие возможно любое число)

int UserInput(string message)
{
    Console.WriteLine(message);
    string? ress = Console.ReadLine();
    int number = Convert.ToInt32(ress);

    return number;
}

int CountDigit(int number)
{
    int digitCount = (int)Math.Log10(number) + 1;

    return digitCount;
}

int UpperBound(int digitCount)
{
    int x = 0;
    if (digitCount % 2 == 0)
    {
        x = digitCount / 2;
    }
    else
    { x = (digitCount - 1) / 2; }

    return x;
}

int FindDigit(int number, int position)
{
    int result = ((int)((number / Math.Pow(10, position - 1)) % 10));
    return result;
}


int number = UserInput(message: "Введите число =>");
int digitCount = CountDigit(number);
int uBound = UpperBound(digitCount);

bool priznak = true;

for (int i = 1; i <= uBound; i++)
{
    int rightNum = FindDigit(number, i);
    int leftNum = FindDigit(number, digitCount - i + 1);

    if (rightNum != leftNum)
    {
        priznak = false;
        break;
    }
}
if (priznak == true)
{
    System.Console.WriteLine($"Введённое число {number} является полиндромом");
}
else
{
    System.Console.WriteLine($"Введённое число {number} не является полиндромом");
}
