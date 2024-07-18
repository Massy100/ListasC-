using System;

public class ListaEnlazada
{
    private Nodo cabeza;

    public ListaEnlazada()
    {
        cabeza = null!;
    }

    // Método para insertar un nodo al final de la lista
    public void Insertar(string nombre, string telefono)
    {
        Nodo nuevoNodo = new Nodo(nombre, telefono);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }

    // Método para listar todos los nodos
    public void Listar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.WriteLine($"Nombre: {actual.Nombre}, Teléfono: {actual.Telefono}");
            actual = actual.Siguiente;
        }
    }

    // Método para buscar un nodo por nombre
    public Nodo BuscarPorNombre(string nombre)
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            if (actual.Nombre == nombre)
            {
                return actual;
            }
            actual = actual.Siguiente;
        }
        return null!;
    }

    // Método para eliminar un nodo por nombre
    public bool EliminarPorNombre(string nombre)
    {
        if (cabeza == null)
        {
            return false;
        }

        if (cabeza.Nombre == nombre)
        {
            cabeza = cabeza.Siguiente;
            return true;
        }

        Nodo actual = cabeza;
        while (actual.Siguiente != null)
        {
            if (actual.Siguiente.Nombre == nombre)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
                return true;
            }
            actual = actual.Siguiente;
        }

        return false;
    }
}
