using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Введите число");
var n1 = Console.ReadLine();
var n = Convert.ToInt32(n1);

Console.WriteLine("Чётные числа:");
for (var i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
