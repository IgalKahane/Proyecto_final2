using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Bienvenido a TU COMPRA OTAKU");

public class Usuario
{
    public int id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string NombreUsuario { get; set; }
    public double Contraseña { get; set; }
    public string Correo { get; set; }

    public Usuario()
    {
        id = 5501;
        Nombre = string.Empty;
        Apellido = string.Empty;
        NombreUsuario = string.Empty;
        Contraseña = 151202;
        Correo = string.Empty;
    }

}
