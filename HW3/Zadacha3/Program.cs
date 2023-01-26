/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

//Ввод верхней границы цикла

int UserInput (string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userNumber = UserInput("Введите число ->");

for(int i = 1; i <= userNumber; i++)
{
    double cube = Math.Pow(i, 3);
    System.Console.WriteLine($"{i} -> {cube}"); 
}
