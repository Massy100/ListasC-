using System;

namespace namespaceUsuario
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Usuario(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Teléfono: {Telefono}");
        }
    }
}