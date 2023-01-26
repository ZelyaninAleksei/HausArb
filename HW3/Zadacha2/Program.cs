// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double UserInput(string message) //Функция пользовательского ввода координаты
{
    System.Console.WriteLine(message);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

//квадрат разности координат
double Result (double dot1,  double dot2)
{
 double qwadro = Math.Pow((dot2-dot1),2);
 return qwadro;
}

double dotAx = UserInput("Введите координату X точки А ->");
double dotAy = UserInput("Введите координату Y точки А ->");
double dotAz = UserInput("Введите координату Z точки А ->");

double dotBx = UserInput("Введите координату X точки B ->");
double dotBy = UserInput("Введите координату Y точки B ->");
double dotBz = UserInput("Введите координату Z точки B ->");

double distance = Math.Round(Math.Sqrt(Result(dotAx, dotBx) + Result(dotAy, dotBy) + Result(dotAz, dotBz)), 2);
System.Console.WriteLine($"Расстояние между точками А и B -> {distance}");