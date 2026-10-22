using System.Diagnostics.CodeAnalysis;


//Factorial de un numero
public class Cuadrados
{


    static void Main(string[] args)
    {
        for(long numero = 0;  numero <= 10; numero++)
        {
            Console.WriteLine("{0}! = {1}", numero, Factorial(numero));
           
        }
        
    }


    public static long Factorial(long numero)
    {
        if (numero <= 1)
        {
            return 1;
        }
        else
        {
            return numero * Factorial(numero - 1);
        }
    }
}