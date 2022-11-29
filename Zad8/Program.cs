// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число");
int n = System.Convert.ToInt32(System.Console.ReadLine());
int d = 1;

while (d <= n)
{
    int k = d % 2;
    if (k == 0)
    {
        System.Console.Write($"{d} ");
        d++;
    }

    else
    {
        d++;
    }
}
