using System.Reflection;

decimal operacion;
string opcion;





void menu()
{
    Console.WriteLine("***************CALCULADORA BASICA***************");

    Console.WriteLine("Operaciones: \n" +
        "1- Sumar\n" +
        "2-Restar\n" +
        "3-Dividir\n" +
        "4-Multiplicar\n" +
        "5-Salir");


    Console.WriteLine("\nSeleccion una opcion: ");
    opcion = Console.ReadLine();


    do
    {
        switch (opcion.ToLower())
        {
            case "sumar":
                Sumar();
                break;
            case "restar":
                Restar();
                break;
            case "dividir":
                Dividir();
                break;
            case "multiplicar":
                Multiplicar();
                break;
            case "salir":
                Salir();
                break;
            default:
                Console.WriteLine("Ingresa una opcion valida");
                break;



        }


        void Sumar()

        {

            Console.Write("Ingresa el primer valor: ");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo valor: ");
            decimal num2 = decimal.Parse(Console.ReadLine());
            operacion = 0;
            operacion = num1 + num2;
            Console.WriteLine($"La operacion de los numeros {num1} + {num2} = {operacion}");
            Console.WriteLine("Quieres realizar otra operacion [si/no]");

            string nuevaOperacion = Console.ReadLine().ToLower();

            if (nuevaOperacion == "si") menu();
            else Salir();

        }

        void Restar()
        {
            Console.Write("Ingresa el primer valor: ");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo valor: ");
            decimal num2 = decimal.Parse(Console.ReadLine());
            operacion = 0;
            operacion = num1 - num2;
            Console.WriteLine($"La operacion de los numeros {num1} - {num2} = {operacion}");
            Console.WriteLine("Quieres realizar otra operacion [si/no]");

            string nuevaOperacion = Console.ReadLine().ToLower();

            if (nuevaOperacion == "si") menu();
            else Salir();

        }

        void Dividir()

        {
            Console.Write("Ingresa el primer valor: ");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo valor: ");
            decimal num2 = decimal.Parse(Console.ReadLine());
            operacion = 0;

            if (num1 <= 0 || num2 <= 0)
            {
                Console.WriteLine("Los dos numeros deben ser mayor a cero");
                Dividir();
            }
            else
            {
                operacion = num1 / num2;
                Console.WriteLine($"La operacion de los numeros {num1} / {num2} = {operacion}");
                Console.WriteLine("Quieres realizar otra operacion [si/no]");

                string nuevaOperacion = Console.ReadLine().ToLower();

                if (nuevaOperacion == "si") menu();
                else Salir();
            }

        }

        void Multiplicar()
        {
            Console.Write("Ingresa el primer valor: ");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo valor: ");
            decimal num2 = decimal.Parse(Console.ReadLine());

            operacion = 0;
            operacion = num1 * num2;

            Console.WriteLine($"La operacion de los numeros {num1} * {num2} = {operacion}");
            Console.WriteLine("Quieres realizar otra operacion [si/no]");

            string nuevaOperacion = Console.ReadLine().ToLower();

            if (nuevaOperacion == "si") menu();
            else Salir();


        }

        void Salir()
        {
            Console.WriteLine("Gracias por usar la calculadora, hasta la proxima");
            Environment.Exit(0);
        }


    } while (opcion != "salir");
}




menu();


