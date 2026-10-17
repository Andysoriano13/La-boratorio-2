//using static System.Runtime.InteropServices.JavaScript.JSType;

//Crear una aplicación de consola que solicite:
//Nombre del cliente.
//Número de cuenta.
//Tipo de cuenta.
//Saldo actual.


//Cliente: Ana Pérez
//Cuenta: 100245
//Tipo: Ahorros
//Saldo: RD$25,500.75 




//Datos introducidos.

Console.Write("Nombre completo: ");
string nombreDelCliente = Console.ReadLine();

Console.Write("Numero de cuenta: ");
int numeroDeCuenta = int.Parse(Console.ReadLine());

Console.Write("Tipo de cuenta [Ahoro/Corriente]: ");
string tipoDeCuenta = Console.ReadLine();

Console.Write("Saldo: ");
decimal saldo = decimal.Parse(Console.ReadLine());




//Impresion de los datos introducido

Console.WriteLine($"Datos del usuario:\n" +
    $"Nombre: {nombreDelCliente}\n" +
    $"numero de cuenta de cuneta: {numeroDeCuenta}\n" +
    $"Tipo de cuenta: {tipoDeCuenta}\n" +
    $"Saldo: RD$ {saldo:N2}");
