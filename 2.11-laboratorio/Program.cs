//using static System.Runtime.InteropServices.JavaScript.JSType;

//Una empresa necesita una aplicación sencilla que permita calcular el salario bruto de un empleado.
//La aplicación debe solicitar:

//Nombre del empleado
//Horas trabajadas
//Pago por hora
//Debe calcular:
//Salario bruto = Horas trabajadas × Pago por hora  
//Finalmente, deberá mostrar un resumen organizado con los datos del empleado y el salario calculado.

//Requisitos técnicos

//Debes utilizar:
//Variables
//Tipos de datos apropiados
//Entrada y salida
//Operadores
//Conversiones
//Interpolación
//Git
//GitHub


Console.Write("Ingrese el nombre de la persona: ");
string nombreEmpleado = Console.ReadLine();

Console.Write("Ingrese las horas trabajas: ");
int horasTrabajadas = int.Parse(Console.ReadLine());

Console.Write("Ingrese el pago por horas: ");
double pagoHoras = double.Parse(Console.ReadLine());

double salarioBruto = horasTrabajadas * pagoHoras;



Console.WriteLine($"\n******************DATOS******************\n" +
    $"Nombre del empleado: {nombreEmpleado}\n" +
    $"Horas trabajadas: {horasTrabajadas}\n" +
    $"Pago por horas: {pagoHoras}\n" +
    $"TOTAL A PAGAR: {salarioBruto}");
