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



    //Clase mostrar detalles......................................................................................................
    public void MostrarDetalles()
    {


        Console.WriteLine("************************************\n");

        Console.WriteLine("{0, -10}{1,-10:N2}{2,-10}", "TIPO", "MONTO", "FECHA Y HORA");
        Console.WriteLine("{0, -10}{1,-10:N2}{2,-10}", Tipo, Monto, Fecha.ToString());

        Console.WriteLine("\n************************************");


    }

}


//Clase Program...............................................................................................................
class Program
{

    static void Main(string[] args)
    {
        Cuenta cuenta = new Cuenta(1000m, "1111", true);
        Teclado teclado = new Teclado();



        Pantalla pantalla = new Pantalla();
        pantalla.MostrarMensaje();
        pantalla.MostrarSaldo(cuenta.ConsultarSaldo());



        decimal comprobador1 = cuenta.Depositar(teclado.LeerMonto());
        if (comprobador1 > 0)
        {

            Transaccion transaccion1 = new Transaccion("Deposito", comprobador1);
            transaccion1.MostrarDetalles();
            pantalla.MostrarSaldo(cuenta.ConsultarSaldo());


        }


        decimal comprobador2 = cuenta.Retirar(teclado.LeerMonto());
        if (comprobador2 > 0)
        {

            Transaccion transaccion2 = new Transaccion("Retiro", comprobador2);
            transaccion2.MostrarDetalles();
            pantalla.MostrarSaldo(cuenta.ConsultarSaldo());

        }

    }
}