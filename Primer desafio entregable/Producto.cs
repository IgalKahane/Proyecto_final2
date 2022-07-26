// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Bienvenido a TU COMPRA OTAKU");

public class Producto
{
    // variables
    public int id { get; set; }
    public string Detalle { get; set; }
    public double precio { get; set; }
    public double PrecioVenta { get; set; }
    public int stock { get; set; }
    public int IdUsuario { get; set; }

    // constructor
    public Producto()
    {
        id = 0325;
        Detalle = string.Empty;
        precio = 4500.80;
        PrecioVenta = 6500.80;
        stock = 450;
        IdUsuario = 44904618;


    }




}
