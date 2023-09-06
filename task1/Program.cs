Console.WriteLine("Введите первое число: ");
var a1 = Console.ReadLine(); 
var a = Convert.ToInt32(a1);

Console.WriteLine("Введите второе число: ");
var b1 = Console.ReadLine();
var b = Convert.ToInt32(b1);

if (a >= b)
{
    Console.WriteLine(a + " - больше");
}
else
{
    Console.WriteLine(b + " - больше");   
}
