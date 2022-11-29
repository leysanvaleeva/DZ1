// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


System.Console.WriteLine("Введите первое число");
int n1 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число отличное от первого");
int n2 = System.Convert.ToInt32(System.Console.ReadLine());

if (n1 > n2)
{
    System.Console.WriteLine($"Первое число {n1} больше второго числа {n2}");
}
else
{
    System.Console.WriteLine($"Первое число {n1} меньше второго числа {n2}");
}