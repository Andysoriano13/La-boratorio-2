
//Desarrolla una aplicación que solicite:
//Nombre del cliente
//Saldo actual
//Monto a depositar
//La aplicación deberá calcular:

//Y mostrar un resumen con el saldo anterior, depósito y nuevo saldo.
//Además, deberás registrar la evolución del proyecto utilizando Git.



public class MiniBanco
{

     string nombreCliente;
     int saldoActual;



    public void Depositar()
    {
        Console.Write("Ingresa la cantidad a depositar: ");
        int monto = int.Parse(Console.ReadLine());

        if(monto <= 0)
        {
            Console.WriteLine("Por favor el monto a depositar debe ser mayor a cero");
        }
        else
        {
            Console.WriteLine("\n................DEPOSITO REALOZADO................\n");
            saldoActual += monto;
        }
    }


    public void MostrarMensaje()
    {
        Console.WriteLine($"Nombre del cliente: {nombreCliente}\n" +
            $"Saldo: {saldoActual}");
    }


    static void Main(string[] args)
    {
        MiniBanco persona1 = new MiniBanco();
        persona1.MostrarMensaje();
        persona1.Depositar();
        persona1.MostrarMensaje();

        
    }
}

