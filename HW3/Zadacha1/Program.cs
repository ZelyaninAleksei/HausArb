// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
/*14212 -> нет
23432 -> да
12821 -> да
*/


int UserInput(string message)
{
    Console.WriteLine(message);
    string? ress = Console.ReadLine();
    int number = Convert.ToInt32(ress);
    return number;
}

bool FiveDigitVer(int number)
{
    if (number <= 9999)
    {
        System.Console.WriteLine($"Введённое число {number} меньше 5 знаков.");
        return false;
    }
    else if (number > 99999)
    {
        System.Console.WriteLine($"Введённое число {number} больше 5 знаков.");
        return false;
    }
    else
    {
        return true;
    }

}
bool Verification(int number)
{
    int startNum1 = number / 10000;
    int startNum2 = number % 10000 / 1000;
    int endNum5 = (number % 100) / 10;
    int endNum6 = number % 10;
    if (startNum1 == endNum6 && startNum2 == endNum5)
    {
        System.Console.WriteLine($"Введённое число {number} является палиндромом");
        return true;
    }
    else
    {
        System.Console.WriteLine($"Введённое число {number} не является палиндромом");
        return false;
    }
}

int number = UserInput("Введите число =>");
if (FiveDigitVer(number))
{
    Verification(number);
}