using System.Security.Cryptography;


double P1 = 0, P2 = 0, P3 = 0, P4 = 0, Examen = 0, TrabajoF = 0, PromedioF = 0, promedioFinal = 0;


Console.WriteLine("Por favor ingresa los siguientes datos:...\n");

Console.WriteLine("Ingresa la primera calificacion: ");
P1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingresa la segunda calificacion: ");
P2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingresa la tercera calificacion: ");
P3 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingresa la cuarta calificacion: ");
P4 = double.Parse(Console.ReadLine());

PromedioF = ((P1 + P2 + P3 + P4) / 4) * 0.55;


Console.WriteLine("Introduce la calificacion del examen:... ");
Examen = double.Parse(Console.ReadLine());

Console.WriteLine("Introduce la calificacion del trabajo final:... ");
TrabajoF = double.Parse(Console.ReadLine());

promedioFinal = (PromedioF + (Examen * 0.30) + (TrabajoF * 0.15));







Console.WriteLine($"Primera calificacion: {P1}\n" +
   $"Segunda calificacion: {P2}\n" +
   $"Tercera calificacion: {P3}\n" +
   $"Cuarta calificacion: {P4}\n" +
   $"Examen: {Examen}\n" +
   $"Trabajo: {TrabajoF}\n" +
   $"Promedio: {PromedioF}\n" +
   $"Promedio Final: {promedioFinal}");







