int heigth;
Console.WriteLine("Ingresar tu estatura: ");
heigth = Convert.ToInt32(Console.ReadLine());

if (heigth <= 150)
{
    Console.WriteLine("Eres un eneano");
}
else if (heigth <= 170)
{
    Console.WriteLine("Eres promedio");
}
else if (heigth <= 200)
{
    Console.WriteLine("Eres alto");
}
else
{
    Console.WriteLine("Eres un gigante");
}

