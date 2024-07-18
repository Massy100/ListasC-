public class Nodo
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public Nodo Siguiente { get; set; }

    public Nodo(string nombre, string telefono)
    {
        Nombre = nombre;
        Telefono = telefono;
        Siguiente = null!;
    }
}
