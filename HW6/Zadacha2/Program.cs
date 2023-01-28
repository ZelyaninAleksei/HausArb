// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void UserInput(double[] coeff, string message)
{
    System.Console.WriteLine($"Введите коэффициенты для уравнений k1, b1, k2, b2");
    for (int i = 0; i <= coeff.Length - 1; i++)
    {
        coeff[i] = Convert.ToDouble(Console.ReadLine());
    }
}

double FindX (double[] coeff)
{
    double x = (coeff[3]-coeff[1])/(coeff[0]-coeff[2]);
    return x;
}


double[] coeff = new double[4];

UserInput(coeff, "Введите коэффиценты для расчёта");
double result = FindX(coeff);

Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine($"Координата X пересечения двух прямых с заданными коэффициентами ---> {result}");
Console.ResetColor();