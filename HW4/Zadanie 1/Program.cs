// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int UserNumEnter (string usernum)
{
    System.Console.WriteLine(usernum);
    int enternum = Convert.ToInt32(Console.ReadLine());
    return enternum;
}

int Erection(int usernum, int userDegree)
{
    int temp = usernum;
    for (int i = 2; i <= userDegree; i++)
    {
    int a = usernum*temp;
    temp = a;
    }
    return temp;
}

int usernum = UserNumEnter("Введите число ->");
int userDegree = UserNumEnter("Введите степень ->");

System.Console.WriteLine($"Число {usernum} в степенеи {userDegree} ---> {Erection(usernum, userDegree)}");