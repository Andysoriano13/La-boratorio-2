class Producto 

{
    public string Codigo {  get; set; }
    public string Nombre { get; set; }

    public decimal Precio { get; set; }
    public int Cantidad { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine("***********************************************************");

        Console.WriteLine("{0,-10}{1,-20}{2,-10:N2}{3,-10}", "CODIGO", "NOMBRE", "PRECIO", "CANTIDAD");
        Console.WriteLine("{0,-10}{1,-20}{2,-10:N2}{3,-10}", Codigo, Nombre, Precio, Cantidad);
        Console.WriteLine("***********************************************************");
    }

    public decimal ConsultarValorTotal()
    {
        return Precio * Cantidad;
    }

}



class Program
{
    static void Main(string[] args)
    {
        Producto pro1 = new Producto();
        pro1.Codigo = "P001";
        pro1.Nombre = "Laptop";
        pro1.MostrarInformacion();
        pro1.Precio = 100m;
        pro1.Cantidad = 5;
        pro1.MostrarInformacion();
        Console.WriteLine("TOTAL: " + pro1.ConsultarValorTotal());
        pro1.Precio = 250m;
        pro1.Cantidad = 0;
        pro1.MostrarInformacion();
        Console.WriteLine("TOTAL: " + pro1.ConsultarValorTotal());




        Console.WriteLine("\n");

        Producto pro2 = new Producto();
        pro2.Codigo = "P002";
        pro2.Nombre = "Iphone";
        pro2.Precio = 150m;
        pro2.Cantidad = 13;
        pro2.MostrarInformacion();
        Console.WriteLine("TOTAL: " + pro2.ConsultarValorTotal());


        Console.WriteLine("\n");

        Producto pro3 = new Producto();
        pro3.Codigo = "P003";
        pro3.Nombre = "Cilla Gamer";
        pro3.Precio = 1000m;
        pro3.Cantidad = 2;
        pro3.MostrarInformacion();
        Console.WriteLine("TOTAL: " + pro3.ConsultarValorTotal());
    }
}
