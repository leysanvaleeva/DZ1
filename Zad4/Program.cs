// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int n1 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число отличное от первого");
int n2 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите третье число отличное от первого и второго");
int n3 = System.Convert.ToInt32(System.Console.ReadLine());
int max = n1;
if ( n2 > max)
{
max = n2;
}
if (n3 > max)
{
max = n3;
}

System.Console.WriteLine($"Максимальное число {max}");