// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число ->");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ->");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum) {
    Console.WriteLine($"Первое число больше второго и равняется {firstNum}, соответствено второе число является наименьшим и равняется {secondNum}");
}
else {
    Console.WriteLine($" Второе число больше первого и равняется {secondNum}, соответствено первое число является наименьшим и равняется {firstNum}");
}