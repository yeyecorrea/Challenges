Console.WriteLine("Ingresa un numero: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.Clear();
    Console.WriteLine($"{num} es par");
}
else
{
    Console.Clear();
    Console.WriteLine($"{num} no es par");
}
