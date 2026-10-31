using System.Diagnostics;


Console.Write("Por favor ingresa tu nombre: ");
string nombre = Console.ReadLine();

Console.Write("Por favor ingresa tu numero de cuenta: ");
string nCuenta = Console.ReadLine();
bool estado = false;
decimal saldo = 10000m;



//FUNCION DEL MENU PRINCIPAL
void Menu()
{
    int opcion;

    do
    {
        Console.WriteLine("*****************BIENBENIDO AL CAJERO AUTOMATICO 'ATM'*****************\n");



        Console.WriteLine("" +
            "1-Ver info de la cuenta\n" +
            "2-Depositar\n" +
            "3-Retirar\n" +
            "4-Salir");


        Console.Write($"\n{nombre} Selecciona la opcion deseada: ");
        if (int.TryParse(Console.ReadLine(), out opcion))
        {
            switch (opcion)
            {
                case 1:
                    verInfo();
                    break;
                case 2:
                    Depositar();
                    break;
                case 3:
                    Retirar();
                    break;
                case 4:
                    Salir();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

        }
        else Console.WriteLine("\nOPCION INCORRECTA, Intentalo de nuevo\n");




    } while (opcion != 4);



}



//FUNCION PARA VER INFORMACION SOBRE LA CUENTA DEL CLIENTE
void verInfo()
{
    Console.WriteLine("\n**********************************************************************************************");
    Console.WriteLine("\t\t{0,-15}{1,-20}{2,-20}{3,-10}", "NOMBRE", "NUMERO DE CUENTA", "ESTADO DE CUENTA", "SALDO");
    Console.WriteLine("\t\t{0,-15}{1,-20}{2,-20}{3,-10:N2}", nombre, nCuenta, estado, saldo);
    Console.WriteLine("************************************************************************************************\n");

    SeguirDentro();
}



// FUNCION HACER DEPOSITOS EN LA CUENTA 

void Depositar()
{

    Console.Write("Ingresa la cantidad a depositar: ");
    decimal cantidad = decimal.Parse(Console.ReadLine());

    if (estado == false) ActivarCuenta();
    
    else
    {
        if (cantidad <= 0)
        {
            Console.WriteLine("La cantidad a depositar debe ser mayor a cero");
            Depositar();

        }
        else
        {
            saldo += cantidad;
            Console.WriteLine($"Deposito realizado, su nuevo saldo es: {saldo:N2}");
            SeguirDentro();




        }

    }

}


//FUENCION PARA RETIRAR DINERO DE LA CUENTA


void Retirar()
{
    Console.Write("Ingresa la cantidad a retirar: ");
    decimal cantidad = decimal.Parse(Console.ReadLine());

    if (estado == false) ActivarCuenta();


    else
    {
        if (cantidad > saldo)
        {
            Console.WriteLine("Saldo insufciente, intentalo de nuevo.");
            Retirar();
        }
        else
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad a retirar debe ser mayor a cero, intentalo de nuevo");
                Retirar();
            }
            else
            {
                saldo -= cantidad;
                Console.WriteLine($"Retiro realizado, su nuevo saldo es: {saldo:N2}");

                SeguirDentro();


            }
        }
    }

}


//SALIR DEL MENU

void Salir()
{
    Console.WriteLine("*******GRACIAS POR UTILIZAR EL SERVICO*******");
    Environment.Exit(0);
}



//OPCION PARA ACTIVAR LA CUENTA CUANDO SE ENCUENTRA INACTIVA
void ActivarCuenta()
{
    Console.Write("Tu cuenta esta inactiva, deceas activarla [si/no]: ");

    string activarCuenta = Console.ReadLine().ToLower();
    if (activarCuenta == "si")
    {
        estado = true;
        Console.WriteLine("\n**********************************************");
        Console.WriteLine("CUENTA ACTIVADA, REALIZA LA ACCION NUEVAMENTE");
        Console.WriteLine("**********************************************\n");

        Menu();
    }


}

// OPCION PARA SABER SI SEGUIR DENTRO O FUERA DEL MENU

void SeguirDentro()
{
    Console.Write("\nDeseas realizar otra operacion [si/no]: ");

    string otraOpcion = Console.ReadLine().ToLower() ;
    if (otraOpcion == "si") Menu();
    else
    {
        if (otraOpcion == "no")
        {
            Salir();
        }
        else Console.WriteLine("Seleccione la opcion correcta");
    }

}

Menu();







