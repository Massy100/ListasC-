using System;
using namespaceUsuario;

namespace namespacePrograma
{
    public class Program
    {
        static Usuario[] contactos = new Usuario[10];
        static int contadorContactos = 0;

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("===== MENÚ PRINCIPAL =====");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Listar contactos");
                Console.WriteLine("3. Buscar contacto por nombre");
                Console.WriteLine("4. Eliminar contacto");
                Console.WriteLine("5. Salir");
                Console.WriteLine("==========================");
                Console.Write("Selecciona una opción: ");

                string input = Console.ReadLine() ?? string.Empty;
                int option;

                if (int.TryParse(input, out option))
                {
                    switch (option)
                    {
                        case 1:
                            AgregarContacto();
                            break;
                        case 2:
                            ListarContactos();
                            break;
                        case 3:
                            BuscarContacto();
                            break;
                        case 4:
                            EliminarContacto();
                            break;
                        case 5:
                            exit = true;
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intenta de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Intenta de nuevo.");
                }

                if (!exit)
                {
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        static void AgregarContacto()
        {
            if (contadorContactos >= contactos.Length)
            {
                Console.WriteLine("No se pueden agregar más contactos. La lista está llena.");
                return;
            }

            Console.Write("Ingresa el nombre del contacto: ");
            string nombre = Console.ReadLine()!;

            Console.Write("Ingresa el teléfono del contacto: ");
            string telefono = Console.ReadLine()!;

            contactos[contadorContactos] = new Usuario(nombre, telefono);
            contadorContactos++;
            Console.WriteLine("Contacto agregado exitosamente.");
        }

        static void ListarContactos()
        {
            if (contadorContactos == 0)
            {
                Console.WriteLine("No hay contactos para mostrar.");
                return;
            }

            Console.WriteLine("Lista de contactos:");
            for (int i = 0; i < contadorContactos; i++)
            {
                contactos[i].MostrarInformacion();
            }
        }

        static void BuscarContacto()
        {
            Console.Write("Ingresa el nombre del contacto a buscar: ");
            string nombre = Console.ReadLine()!;
            bool encontrado = false;

            for (int i = 0; i < contadorContactos; i++)
            {
                if (contactos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    contactos[i].MostrarInformacion();
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }

        static void EliminarContacto()
        {
            Console.Write("Ingresa el nombre del contacto a eliminar: ");
            string nombre = Console.ReadLine()!;
            bool encontrado = false;

            for (int i = 0; i < contadorContactos; i++)
            {
                if (contactos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < contadorContactos - 1; j++)
                    {
                        contactos[j] = contactos[j + 1];
                    }
                    contactos[contadorContactos - 1] = null!;
                    contadorContactos--;
                    Console.WriteLine("Contacto eliminado exitosamente.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }
    }
}

