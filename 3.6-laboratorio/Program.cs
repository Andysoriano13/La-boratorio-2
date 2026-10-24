Console.Write("Ingresa el nombre del estudiante: ");
string nombreEstudiante  = Console.ReadLine();

Console.Write("Ingresa la calificiacion: ");
string entrada = Console.ReadLine();
decimal calificacion;

if (!decimal.TryParse(entrada, out calificacion))
{
    Console.WriteLine("Debes de escribir un dato valido");
}
else
{
    if(calificacion <= 0 ||  calificacion > 100)
    {
        Console.WriteLine("Calificacion no validad");
    }

    if(calificacion >= 90 &&  calificacion <= 100)
    {
        Console.WriteLine($"Buenas noticias {nombreEstudiante} tu califiacion fue 'EXCELENTE' ");
    }

    if (calificacion >= 80 && calificacion < 90)
    {
        Console.WriteLine($"Buenas noticias {nombreEstudiante} tu califiacion fue 'BUENA' ");
    }

    if (calificacion >= 70 && calificacion < 80)
    {
        Console.WriteLine($"Buenas noticias {nombreEstudiante} 'APROBASTE EL CURSO CON EL MINIMO' ");
    }

    if (calificacion > 0 && calificacion < 70 )
    {
        Console.WriteLine($"Malas noticias {nombreEstudiante} 'REPROBASTE' ");
    }
}

Console.ReadLine();