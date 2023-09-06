Console.WriteLine("Введите первое число: ");
var a1 = Console.ReadLine(); 
var a = Convert.ToInt32(a1);

Console.WriteLine("Введите второе число: ");
var b1 = Console.ReadLine();
var b = Convert.ToInt32(b1);

Console.WriteLine("Введите третье число: ");
var c1 = Console.ReadLine(); 
var c = Convert.ToInt32(c1);

int max;
if (a >= b)
{
    max = a;
}
else
{
    max = b;   
}

if (max >= c)
{
    Console.WriteLine(max + " - больше");
}
else
{
    Console.WriteLine(c + " - больше");   
}
