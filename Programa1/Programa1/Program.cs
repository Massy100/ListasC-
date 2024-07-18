using System;

namespace ProgramaNamespace
{
    class Programa
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();
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
                            AgregarContacto(lista);
                            break;
                        case 2:
                            ListarContactos(lista);
                            break;
                        case 3:
                            BuscarContactoPorNombre(lista);
                            break;
                        case 4:
                            EliminarContacto(lista);
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

        static void AgregarContacto(ListaEnlazada lista)
        {
            Console.Write("Introduce el nombre del contacto: ");
            string nombre = Console.ReadLine()!;
            Console.Write("Introduce el número de teléfono del contacto: ");
            string telefono = Console.ReadLine()!;
            lista.Insertar(nombre!, telefono!);
            Console.WriteLine("Contacto agregado correctamente.");
        }

        static void ListarContactos(ListaEnlazada lista)
        {
            Console.WriteLine("Lista de contactos:");
            lista.Listar();
        }

        static void BuscarContactoPorNombre(ListaEnlazada lista)
        {
            Console.Write("Introduce el nombre a buscar: ");
            string nombre = Console.ReadLine()!;
            Nodo encontrado = lista.BuscarPorNombre(nombre!);
            if (encontrado != null)
            {
                Console.WriteLine($"Contacto encontrado: Nombre: {encontrado.Nombre}, Teléfono: {encontrado.Telefono}");
            }
            else
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }

        static void EliminarContacto(ListaEnlazada lista)
        {
            Console.Write("Introduce el nombre del contacto a eliminar: ");
            string nombre = Console.ReadLine()!;
            bool eliminado = lista.EliminarPorNombre(nombre!);
            if (eliminado)
            {
                Console.WriteLine("Contacto eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }
    }
}
