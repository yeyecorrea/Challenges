int options = 0;
while (options != 4)
{
    Console.WriteLine(@"Bienvenido al cajero, que deseas hacer hoy:
       1 - Ver saldo
       2 - Retirar
       3 - Depositar
       4 - Salir
    ");
    options = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    switch (options)
    {
        case 1:
            Console.WriteLine($@"Saldo
             - Tu saldo es de {0:C2}
            ");
            break;
        case 2:
            Console.WriteLine(@"Retirar
            - Cuanto desas retirar?
            ");
            break;
        case 3:
            Console.WriteLine(@"Deposito
            - Cuanto deseas depositar?
            ");
            break;
        case 4:
            Console.WriteLine("Salida del sistema");
            break;
    }
}


