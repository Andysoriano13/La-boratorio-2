
// No sabia en que lugar implementar esta clase, la deje afuera con el fin de seguir practicando
// y añadirla en su lugar correspondiente.
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

// CLASE ATM

class ConsolaATM
{
    //METODOS PARA PANTALLA
    public void MostrarMensaje(decimal confirmar)
    {
        if (confirmar == 0) Console.WriteLine("El monto debe de ser mayor a 0");
        else
        {
            if (confirmar == -1) Console.WriteLine("Fondos insuficientes");



        }
    }

    public void MostrarSaldo(decimal saldo)
    {
        Console.WriteLine("******************************************************\n");

        Console.WriteLine($"Su saldo actual es:   {saldo:N2}");

        Console.WriteLine("\n******************************************************");


    }


    // METODOS PARA TECLADO

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

    // METODO PARA MOSTRAR EL MENU

    public void MostrarMenu()
    {


        Console.WriteLine("*****************BIENVENIDO AL CAJERO AUTOMATICO 'ATM'*****************\n");



        Console.WriteLine("" +
            "1-Consultar saldo\n" +
            "2-Depositar\n" +
            "3-Retirar\n" +
            "4-Salir");



    }


}



class ServicioATM
{
    public CuentaBancaria CuentaActual { get; set; }

    public ServicioATM(CuentaBancaria cuentaActual)
    {
        CuentaActual = cuentaActual;
    }

    // METODO PARA EJECUTAR UNA OPERACION

    public int EjecutarOperacion()
    {
        ConsolaATM consolaATM = new ConsolaATM();



        switch (consolaATM.LeerOpcion())
        {
            case 1:


                consolaATM.MostrarSaldo(CuentaActual.ConsultarSaldo());

                return 1;

            case 2:

                decimal validarDep = CuentaActual.Depositar(consolaATM.LeerMonto());

                if (validarDep == 0 || validarDep == -1) consolaATM.MostrarMensaje(validarDep);

                else if (validarDep != 0)
                {
                    Transaccion transaccion1 = new Transaccion("deposito", validarDep);
                    transaccion1.MostrarDetalles();
                    consolaATM.MostrarSaldo(CuentaActual.ConsultarSaldo());


                }



                return 2;




            case 3:


                decimal validarRet = CuentaActual.Retirar(consolaATM.LeerMonto());
                if (validarRet == 0 || validarRet == -1)
                {
                    consolaATM.MostrarMensaje(validarRet);

                }
                else
                {
                    if (validarRet != 0)
                    {
                        Transaccion transaccion2 = new Transaccion("retiro", validarRet);
                        transaccion2.MostrarDetalles();
                        consolaATM.MostrarSaldo(CuentaActual.ConsultarSaldo());
                    }
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


class CuentaBancaria
{
    public string NumeroCuenta { get; set; }
    private decimal Saldo { get; set; }
    public bool Activa { get; set; }


    public CuentaBancaria(decimal saldo, string numeroCuenta, bool activa)
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
            Saldo += valor;
            return valor;

        }
        else
        {
            return 0; //El monto debe de ser mayor a cero
        }





    }


    public decimal Retirar(decimal valor)
    {


        if (valor > Saldo)
        {

            return -1; // Solo si el saldo es insuficiente

        }
        else
        {
            if (valor <= 0)
            {

                return 0; // Solo si el saldo es menor o igual a 0
            }

            else
            {
                Saldo -= valor;



            }


        }
        return valor;







    }


}

class Program
{

    static void Main(string[] args)
    {
        CuentaBancaria cuenta = new CuentaBancaria(1000m, "1111", true);  //Instancia de la clase cuenta
        ServicioATM myAtm = new ServicioATM(cuenta);
        ConsolaATM consolaATM = new ConsolaATM();




        do
        {
            consolaATM.MostrarMenu();

        } while (myAtm.EjecutarOperacion() != 4);


    }
}