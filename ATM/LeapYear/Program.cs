using LeapYear;

try
{
    Console.WriteLine("Ingresa un año: ");
    int year = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nIngresa un mes: ");
    int month = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nIngresa un dia: ");
    int day = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    Date dato1 = new Date(year, month, day);
    Console.WriteLine(dato1);
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}