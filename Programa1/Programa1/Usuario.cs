// Persona.cs
using System;

namespace UsuarioNamespace
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Numero { get; set; }
        
        public Usuario()
        {
            //
        }

        public Usuario(string nombre, string apellido, string numero)
        {
            Nombre = nombre;
            Apellido = apellido;
            Numero = numero;
        }

        public string ObtenerNombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre Completo: {ObtenerNombreCompleto()}");
            Console.WriteLine($"Numero: {Numero}");
        }
    }
}