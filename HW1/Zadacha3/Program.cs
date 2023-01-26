// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число ->");
int firstNum = Convert.ToInt32(Console.ReadLine());

if (firstNum%2==0) {
Console.WriteLine($"Введённое число {firstNum} является чётным");    
}
else {
Console.WriteLine($"Введённое число {firstNum} не является чётным");    
}