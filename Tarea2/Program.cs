Console.WriteLine("Bienvenido, por favor llanar los siguientes espacios: \n");

Console.WriteLine("Ingresa tu nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine("Profesion o Carrera: ");
string profesion = Console.ReadLine();

Console.WriteLine("Motivo por el cual estudia: ");
string motivoE = Console.ReadLine();

Console.WriteLine($"\n" +
    $"Nombre: {nombre}\n" +
    $"Profesion: {profesion}\n" +
    $"Motivo de estudio: {motivoE}");