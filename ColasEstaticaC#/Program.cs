using System;
class profram
{
    static int[] miCola = new int[10]; // Tamaño fijo del arreglo para la cola
    static int frente = -1;
    static int fin = -1;

    static void Main(string[] args)
    {
        int a = 1;

        do
        {
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Agregar elemento a la cola");
            Console.WriteLine("2. Eliminar elemento de la cola");
            Console.WriteLine("3. Imprimir la cola");
            Console.WriteLine("4. Salir");

            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el elemento a agregar: ");
                        string entrada = Console.ReadLine();
                        int elementoAgregar;

                        if (int.TryParse(entrada, out elementoAgregar))
                        {
                            EnqueueElemento(elementoAgregar);
                        }
                        else
                        {
                            Console.WriteLine("Por favor, ingrese un valor entero válido.");
                        }
                        break;
                    case 2:
                        DequeueElemento();
                        break;
                    case 3:
                        ImprimirCola();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa.");
                        a = 2;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }

        } while (a == 1);
    }

    // Método para insertar elementos en la cola
    static void EnqueueElemento(int elemento)
    {
        if (fin == miCola.Length - 1)
        {
            Console.WriteLine("La cola está llena. No se puede agregar más elementos.");
        }
        else
        {
            fin++;
            miCola[fin] = elemento;
            Console.WriteLine($"Se agregó el elemento {elemento} a la cola.");
        }

        if (frente == -1)
        {
            frente = 0;
        }
    }

    // Método para eliminar un elemento de la cola
    static void DequeueElemento()
    {
        if (frente == -1)
        {
            Console.WriteLine("La cola está vacía. No se puede eliminar ningún elemento.");
        }
        else
        {
            int elementoEliminado = miCola[frente];
            Console.WriteLine($"Se eliminó el elemento {elementoEliminado} de la cola.");
            frente++;

            if (frente > fin)
            {
                frente = -1;
                fin = -1;
            }
        }
    }

    // Método para imprimir la cola
    static void ImprimirCola()
    {
        if (frente == -1)
        {
            Console.WriteLine("La cola está vacía.");
        }
        else
        {
            Console.Write("Contenido de la cola: ");
            for (int i = frente; i <= fin; i++)
            {
                Console.Write(miCola[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
