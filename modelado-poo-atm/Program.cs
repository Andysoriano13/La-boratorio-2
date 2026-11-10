
using System.Drawing;
using System.Security.AccessControl;

// Clase cuenta......................................................................................................
class Cuenta
{
    public string NumeroCuenta { get; set; }
    private decimal Saldo { get; set; }
    public bool Activa { get; set; }


    public Cuenta(decimal saldo, string numeroCuenta, bool activa)
    {
        Saldo = saldo;
        NumeroCuenta = numeroCuenta;
        Activa = activa;
    }


    public decimal ConsultarSaldo()
    {
        return Saldo;


    }

    public decimal Depositar(decimal valor)
    {

        if (valor > 0)
        {
            Console.WriteLine("Deposito realizado....");
            Saldo += valor;
            return valor;

        }
        else
        {
            Console.WriteLine("El monto a depositar debe de ser mayor a cero.");
            return 0;
        }





    }


    public decimal Retirar(decimal valor)
    {


        if (valor > Saldo)
        {
            Console.WriteLine("Fondos insuficientes");
            return 0;

        }
        else
        {
            if (valor <= 0)
            {
                Console.WriteLine("El monto debe de ser mayor a cero.");
                return 0;
            }

            else
            {
                Console.WriteLine("Retiro realizado.");
                Saldo -= valor;



            }


        }
        return valor;







    }

}

//Clase pantalla.................................................................................................................

class Pantalla()
{

    public void MostrarMensaje()
    {
        Console.WriteLine("**CAJERO AUTOMATICO");
    }

    public void MostrarSaldo(decimal saldo)
    {
        Console.WriteLine("******************************************************\n");

        Console.WriteLine($"Su saldo actual es:   {saldo:N2}");

        Console.WriteLine("\n******************************************************");


    }



}



//Clase teclado...........................................................................................................
class Teclado()
{
    public decimal LeerMonto()
    {
        decimal valor;
        Console.Write("Ingresa el monto: ");
        while (!decimal.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Datos incorrectos, por favor ingrese un dato valido...");
            Console.Write("Ingresa el monto  nuevamente: ");
        }

        return valor;
    }

    public int LeerOpcion()
    {
        int opcion;
        Console.Write($"\nSelecciona la opcion deseada: ");
        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion > 5 || opcion <= 0)
        {
            Console.WriteLine("La opcion seleccionada es incorrecta");
            Console.Write("Intentalo de nuevo: ");

        }
        return opcion;


    }





}

//Clase transaccion............................................................................................................

class Transaccion
{
    public string Tipo { get; set; }
    public decimal Monto { get; set; }
    public DateTime Fecha = DateTime.Now;

    public Transaccion(string tipo, decimal monto)
    {
        Tipo = tipo;
        Monto = monto;

    }




    public void MostrarDetalles()
    {

        if (Tipo.ToLower() == "deposito" || Tipo.ToLower() == "retiro")
        {
            Console.WriteLine("************************************\n");

            Console.WriteLine("{0, -10}{1,-10:N2}{2,-10}{3,-10}", "TIPO", "MONTO", "FECHA \t", "HORA");
            Console.WriteLine("{0, -10}{1,-10:N2}{2,-10}{3,-10}", Tipo, Monto, Fecha.ToString("dd/MM/yyyy \t"), Fecha.ToString("HH:mm:ss"));

            Console.WriteLine("\n************************************");

        }




    }

}

//ATM.......................................................................................................................

class Atm
{



    public Cuenta CuentaActual { get; set; }

    public Atm(Cuenta cuentaActual)
    {
        CuentaActual = cuentaActual;
    }




    public void MostrarMenu()
    {


        Console.WriteLine("*****************BIENVENIDO AL CAJERO AUTOMATICO 'ATM'*****************\n");



        Console.WriteLine("" +
            "1-Consultar saldo\n" +
            "2-Depositar\n" +
            "3-Retirar\n" +
            "4-Salir");
        //"4-Consultar moviminetos de cuenta \n" +
        //"5-Salir");





    }

    public int EjecutarOperacion()
    {
        Teclado teclado = new Teclado();
        Pantalla pantalla = new Pantalla();


        switch (teclado.LeerOpcion())
        {
            case 1:

                pantalla.MostrarMensaje();
                pantalla.MostrarSaldo(CuentaActual.ConsultarSaldo());

                return 1;

            case 2:

                decimal validarDep = CuentaActual.Depositar(teclado.LeerMonto());
                if (validarDep != 0)
                {
                    Transaccion transaccion1 = new Transaccion("deposito", validarDep);
                    transaccion1.MostrarDetalles();
                    pantalla.MostrarSaldo(CuentaActual.ConsultarSaldo());


                }



                return 2;

            case 3:


                decimal validarRet = CuentaActual.Retirar(teclado.LeerMonto());
                if (validarRet != 0)
                {
                    Transaccion transaccion2 = new Transaccion("retiro", validarRet);
                    transaccion2.MostrarDetalles();
                    pantalla.MostrarSaldo(CuentaActual.ConsultarSaldo());
                }

                return 3;

            case 4:
                Console.WriteLine("****************************************************");
                Console.WriteLine("\nGracias por utilizar nuestro servicio\n");
                Console.WriteLine("****************************************************");
                return 4;
            default:
                Console.WriteLine("Fuera de alcance");
                return 0;
        }


    }
}


//Clase Program...............................................................................................................

class Program
{

    static void Main(string[] args)
    {
        Cuenta cuenta = new Cuenta(1000m, "1111", true);  //Instancia de la clase cuenta
        Atm myAtm = new Atm(cuenta);




        do
        {
            myAtm.MostrarMenu();

        } while (myAtm.EjecutarOperacion() != 4);


    }
}



