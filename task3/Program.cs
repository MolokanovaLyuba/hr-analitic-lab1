Console.WriteLine("Введите число: ");
var a1 = Console.ReadLine(); 
var a = Convert.ToInt32(a1);

if (a % 2 == 0)
{
    Console.WriteLine(a + " - чётное");
}
else
{
    Console.WriteLine(a + " - нечётное");
}
