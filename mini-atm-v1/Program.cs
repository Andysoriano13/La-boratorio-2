using System.Diagnostics;

//PSEUDOCODIGO

/*
    // Declaración de variables globales del programa
    Definir nombre Como Cadena
    Definir nCuenta Como Cadena
    Definir estado Como Logico
    Definir saldo Como Real
    
    // Inicialización de valores
    estado <- Falso
    saldo <- 10000.00
    
    Escribir "Por favor ingresa tu nombre: "
    Leer nombre
    
    Escribir "Por favor ingresa tu numero de cuenta: "
    Leer nCuenta
    
    // Llamada inicial a la función/proceso del menú
    Llamar Menu(nombre, nCuenta, estado, saldo)
FinProceso


// Subproceso o función principal del Menú
SubProceso Menu(nombre, nCuenta, estado, saldo)
    Definir opcion Como Entero
    
    Repetir
        Escribir "*****************BIENBENIDO AL CAJERO AUTOMATICO 'ATM'*****************\n"
        Escribir "1-Ver info de la cuenta"
        Escribir "2-Depositar"
        Escribir "3-Retirar"
        Escribir "4-Salir"
        
        Escribir Sin Saltar "\n", nombre, " Selecciona la opcion deseada: "
        Leer opcion
        
        Segun opcion Hacer
            1:
                Llamar verInfo(nombre, nCuenta, estado, saldo)
            2:
                Llamar Depositar(estado, saldo)
            3:
                Llamar Retirar(estado, saldo)
            4:
                Llamar Salir()
            De Otro Modo:
                Escribir "Opcion no valida"
        FinSegun
        
    Hasta Que opcion = 4
FinSubProceso


// Subproceso para ver la información
SubProceso verInfo(nombre, nCuenta, estado, saldo)
    Definir otraOpcion Como Cadena
    
    Escribir "\n**********INFORMACION DE CLIENTE**********\n"
    Escribir "Nombre: ", nombre
    Escribir "Numero de cuenta: ", nCuenta
    Escribir "Estado de la cuenta: ", estado
    Escribir "Saldo: ", saldo, "\n"
    
    Escribir "\nDeseas realizar otra operacion [si/no]: "
    Leer otraOpcion
    
    Si otraOpcion = "si" Entonces
        Llamar Menu(nombre, nCuenta, estado, saldo)
    Sino
        Llamar Salir()
    FinSi
FinSubProceso


// Subproceso para depositar
SubProceso Depositar(estado, saldo)
    Definir cantidad Como Real
    Definir activarCuenta Como Cadena
    Definir otraOpcion Como Cadena
    
    Escribir "Ingresa la cantidad a depositar: "
    Leer cantidad
    
    Si estado = Falso Entonces
        Escribir "Tu cuenta esta inactiva, deceas activarla [si/no]"
        Leer activarCuenta
        
        Si activarCuenta = "si" Entonces
            estado <- Verdadero
            Escribir "Cuenta activada, intenta depositar nuevamente"
            Llamar Depositar(estado, saldo)
        Sino
            // Nota: En el pseudocódigo idealmente pasarías el nombre y cuenta si deseas volver al menú principal
            Retornar
        FinSi
    Sino
        Si cantidad <= 0 Entonces
            Escribir "La cantidad a depositar debe ser mayor a cero"
            Llamar Depositar(estado, saldo)
        Sino
            saldo <- saldo + cantidad
            Escribir "Deposito realizado, su nuevo saldo es: ", saldo
            
            Escribir "\nDeseas realizar otra operacion [si/no]: "
            Leer otraOpcion
            
            Si otraOpcion = "si" Entonces
                Retornar
            Sino
                Llamar Salir()
            FinSi
        FinSi
    FinSi
FinSubProceso


// Subproceso para retirar
SubProceso Retirar(estado, saldo)
    Definir cantidad Como Real
    Definir activarCuenta Como Cadena
    Definir otraOpcion Como Cadena
    
    Escribir "Ingresa la cantidad a retirar: "
    Leer cantidad
    
    Si estado = Falso Entonces
        Escribir "Tu cuenta esta inactiva, deceas activarla [si/no]"
        Leer activarCuenta
        
        Si activarCuenta = "si" Entonces
            estado <- Verdadero
            Escribir "Cuenta activada, intenta retirar nuevamente"
            Llamar Retirar(estado, saldo)
        Sino
            Retornar
        FinSi
    Sino
        Si cantidad > saldo Entonces
            Escribir "Saldo insufciente, intentalo de nuevo."
            Llamar Retirar(estado, saldo)
        Sino
            Si cantidad < 0 Entonces
                Escribir "La cantidad a retirar debe ser mayor a cero, intentalo de nuevo"
                Llamar Retirar(estado, saldo)
            Sino
                saldo <- saldo - cantidad
                Escribir "Retiro realizado, su nuevo saldo es: ", saldo
                
                Escribir "\nDeseas realizar otra operacion [si/no]: "
                Leer otraOpcion
                
                Si otraOpcion = "si" Entonces
                    Retornar
                Sino
                    Llamar Salir()
                FinSi
            FinSi
        FinSi
    FinSi
FinSubProceso


// Subproceso para salir
SubProceso Salir()
    Escribir "*******GRACIAS POR UTILIZAR EL SERVICO*******"
    // Finalizar programa (equivalente a Environment.Exit)
    FinProceso
FinSubProceso

*/


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



        Console.WriteLine("" +
            "1-Ver info de la cuenta\n" +
            "2-Depositar\n" +
            "3-Retirar\n" +
            "4-Salir");


        Console.Write($"\n{nombre} Selecciona la opcion deseada: ");
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

            if (estado == false)
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
                if (cantidad <= 0)
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
                }
                else Menu();

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

