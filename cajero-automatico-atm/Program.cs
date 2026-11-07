
bool estado = false;
decimal saldo = 5000m;

List<string> movimientos = new List<string>();



//FUNCION DEL MENU PRINCIPAL.................................................................................
void MostrarMenu()
{
    int opcion;
    bool salir = false;

    do
    {
        Console.WriteLine("*****************BIENVENIDO AL CAJERO AUTOMATICO 'ATM'*****************\n");



        Console.WriteLine("" +
            "1-Consultar saldo\n" +
            "2-Depositar\n" +
            "3-Retirar\n" +
            "4-Consultar moviminetos de cuenta \n" +
            "5-Salir");


        Console.Write($"\nSelecciona la opcion deseada: ");
        if (int.TryParse(Console.ReadLine(), out opcion))
        {
            switch (opcion)
            {
                case 1:
                    ConsultarSaldo();
                    break;
                case 2:
                    Depositar();
                    break;
                case 3:
                    Retirar();
                    break;
                case 4:
                    MostrarMovimientos();
                    break;
                case 5:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

        }
        else Console.WriteLine("\nOPCION INCORRECTA, Intentalo de nuevo\n");






    } while (!salir);



}



//FUNCION PARA VER INFORMACION SOBRE LA CUENTA DEL CLIENTE...........................................................
void ConsultarSaldo()
{

    Console.WriteLine($"Su saldo es:  {saldo:N2}");
}



// FUNCION HACER DEPOSITOS EN LA CUENTA ...................................................................

void Depositar()

{

    if (estado == false)
    {
        Console.Write("Cuenta inactiva, para continuar debe activar [si/no]: ");
        string activarCuenta = Console.ReadLine().ToLower();
        ActivarCuenta(activarCuenta);
    }

    else
    {
        decimal cantidad = LeerMonto();
        if (cantidad <= 0) Console.WriteLine("El monto a depositar debe der ser mayor a cero");

        else
        {
            if (cantidad > 0)
            {
                saldo += cantidad;
                Console.WriteLine($"Deposito realizado, su nuevo saldo es: {saldo:N2}");
                RegistrarMovimiento(cantidad, "deposito");

            }


        }
    }
}

    //FUENCION PARA RETIRAR DINERO DE LA CUENTA..................................................................


    void Retirar()
    {


        if (estado == false)
        {
            Console.Write("Cuenta inactiva, para continuar debe activar [si/no]: ");
            string activarCuenta = Console.ReadLine().ToLower();
            ActivarCuenta(activarCuenta);
        }



        else
        {
            decimal cantidad = LeerMonto();
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad a retirar debe ser mayor a cero, intentalo de nuevo");

            }
            else
            {
                if (cantidad > saldo)
                {
                    Console.WriteLine("Fondos insuficientes...");
                }
                else
                {
                    saldo -= cantidad;
                    Console.WriteLine($"Retiro realizado, su nuevo saldo es: {saldo:N2}");
                    RegistrarMovimiento(cantidad, "retiro");

                }


            }
        }


    }



    //Leer Monto..............................................................................................
    decimal LeerMonto()
    {
        Console.Write("Ingresa el valor: ");
        decimal valor;
        while (!decimal.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Valor invalido, intenta de nuevo");
            Console.Write("Ingresa el valor: ");
        }

        return valor;
    }


    //Registrar movimineto......................................................................................

    void RegistrarMovimiento(decimal valor, string texto)
    {
        if (texto == "retiro")
        {
            movimientos.Add(
            "\nRETIRO REALIZADO \n" + "\n" +
            "Mondo RD$: " + valor.ToString("N2") + "\n" +
            "Fecha y hora : " + DateTime.Now.ToString());
        }

        if (texto == "deposito")
        {
            movimientos.Add(
            "\nDEPOSITO REALIZADO \n" + "\n" +
            "Mondo RD$: " + valor.ToString("N2") + "\n" +
            "Fecha y hora : " + DateTime.Now.ToString());
        }



    }

    // Mostrar movimientos..........................................................................................
    void MostrarMovimientos()
    {
        if (movimientos.Count == 0)
        {
            Console.WriteLine("No hay has realizado ningun movimiento..");
        }
        else
        {
            foreach (var item in movimientos)
            {
                Console.WriteLine(item);
            }

        }

    }


    //Activar Cuenta.................................................................................................
    void ActivarCuenta(string entrada)
    {
        if (entrada == "si")
        {
            estado = true;
            Console.WriteLine("Cuenta activa...");
        }
        else
        {
            if (entrada == "no")
            {
                Console.WriteLine("La cuenta sigue inactiva, debes de activarla para hacer una transaccion");
            }
            else
            {
                Console.WriteLine("Valor incorrecto");
            }
        }
    }

MostrarMenu();







