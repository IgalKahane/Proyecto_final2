using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProductoVendido
{
    public int Id { get; set; }
    public int idProducto { get; set; }
    public int Stock { get; set; }
    public int IdVenta { get; set; }

    public ProductoVendido()
    {
        Id = 5501;

        idProducto = 0015;

        Stock = 450;

        IdVenta = 0325;

    }

}
