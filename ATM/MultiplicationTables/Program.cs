int[] tables = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};

for (int i = 1; i < tables.Length; i++)
{
    Console.WriteLine($"\n----------Tabla: {i}----------\n");
    for (int j = 1; j <= 12; j++)
    {
        int result = i * j;
        Console.WriteLine($"{i} X {j} = {result}");
    }
}