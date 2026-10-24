using System.Diagnostics;


Console.Write("Por favor ingresa tu nombre: ");
string nombre = Console.ReadLine();

Console.Write("Por favor ingresa tu numero de cuenta: ");
string nCuenta = Console.ReadLine();
bool estado = false;
decimal saldo = 10000m;



 void Menu()
{
    int opcion;
    do
    {
        Console.WriteLine("*****************BIENBENIDO AL CAJERO AUTOMATICO 'ATM'*****************\n");

        Console.WriteLine($"\n {nombre} Selecciona la opcion deseada\n");

        Console.WriteLine("" +
            "1-Ver info de la cuenta\n" +
            "2-Depositar\n" +
            "3-Retirar\n" +
            "4-Salir");



        opcion = int.Parse(Console.ReadLine());

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


        void verInfo()
        {
            Console.WriteLine("\n**********INFORMACION DE CLIENTE**********\n");
            Console.WriteLine($"Nombre: {nombre}\n" +
                $"Numero de cuenta: {nCuenta}\n" +
                $"Estado de la cuenta: {estado}\n" +
                $"Saldo: {saldo}\n");



            Console.Write("\nDeseas realizar otra operacion [si/no]: ");

            string otraOpcion = Console.ReadLine();
            if (otraOpcion == "si") Menu();
            else Salir();
        }

        void Depositar()
        {

            Console.Write("Ingresa la cantidad a depositar: ");
            decimal cantidad = decimal.Parse(Console.ReadLine());

            if(estado == false)
            {
                Console.WriteLine("Tu cuenta esta inactiva, deceas activarla [si/no]");

                string activarCuenta = Console.ReadLine();

                if (activarCuenta == "si")
                {
                    estado = true;
                    Console.WriteLine("Cuenta activada, intenta depositar nuevamente");
                    
                    Depositar();

                }
                else Menu();

            }
            else
            {
                if(cantidad <= 0)
                {
                    Console.WriteLine("La cantidad a depositar debe ser mayor a cero");
                    Depositar();

                }
                else
                {
                    saldo += cantidad;
                    Console.WriteLine($"Deposito realizado, su nuevo saldo es: {saldo}");

                    Console.Write("\nDeseas realizar otra operacion [si/no]: ");

                    string otraOpcion = Console.ReadLine();
                    if (otraOpcion == "si") Menu();
                    else Salir();

                }
                    
            }
            
        }


        void Retirar()
        {
            Console.Write("Ingresa la cantidad a retirar: ");
            decimal cantidad = decimal.Parse(Console.ReadLine());

            if (estado == false)
            {
                Console.WriteLine("Tu cuenta esta inactiva, deceas activarla [si/no]");

                string activarCuenta = Console.ReadLine();

                if (activarCuenta == "si")
                {
                    estado = true;
                    Console.WriteLine("Cuenta activada, intenta retirar nuevamente");
                    Retirar();
                }else Menu();
                
            }
            else
            {
                if (cantidad > saldo)
                {
                    Console.WriteLine("Saldo insufciente, intentalo de nuevo.");
                    Retirar();
                }
                else
                {
                    if (cantidad < 0)
                    {
                        Console.WriteLine("La cantidad a retirar debe ser mayor a cero, intentalo de nuevo");
                        Retirar();
                    }
                    else
                    {
                        saldo -= cantidad;
                        Console.WriteLine($"Retiro realizado, su nuevo saldo es: {saldo}");

                        Console.Write("\nDeseas realizar otra operacion [si/no]: ");

                        string otraOpcion = Console.ReadLine();
                        if (otraOpcion == "si") Menu();
                        else Salir();


                    }
                }
            }

        }


        void Salir()
        {
            Console.WriteLine("*******GRACIAS POR UTILIZAR EL SERVICO*******");
            Environment.Exit(0);
        }



        

        


    } while (opcion != 4);



}

Menu();

