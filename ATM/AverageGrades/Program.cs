double[] grades = { 5.0, 2.4, 1.1, 4.0, 4.5, 5.0, 1.3, 1.4, 2.5, 2.8 };
double addition = 0;
foreach (double grade in grades)
{
	addition += grade;
}
double average = (addition / grades.Length);

Console.WriteLine($"Promedio: {average}");
if (average < 3)
{
    Console.WriteLine("No pasastes");
}
else
{
    Console.WriteLine("Si pasastes");
}