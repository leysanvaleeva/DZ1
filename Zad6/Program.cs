// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число");
int num = System.Convert.ToInt32(System.Console.ReadLine());

int k = num % 2;

if (k==0) 
{
    System.Console.WriteLine($"Число четное");
}
else
{
    System.Console.WriteLine($"Число нечетное");
}