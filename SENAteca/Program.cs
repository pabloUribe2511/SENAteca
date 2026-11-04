using System;

class Program
{
    static void Main(string[] args)
    {
        // Permite mostrar tildes y ñ correctamente en la consola
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        ShowMainMenu();
    }

    // ==================== MENÚ PRINCIPAL ====================
    static void ShowMainMenu()
    {
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("              SENAteca");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Salir");
            Console.WriteLine("------------------------------------");

            int opcion = ReadOption("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    ShowBooksMenu();
                    break;
                case 2:
                    ShowUsersMenu();
                    break;
                case 3:
                    ShowLoansMenu();
                    break;
                case 4:
                    ShowSearchReportsMenu();
                    break;
                case 5:
                    ShowPersistenceMenu();
                    break;
                case 6:
                    Console.WriteLine("Saliendo de SENAteca...");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Pause();
                    break;
            }
        }
    }

    // ==================== SUBMENÚS (por ahora solo "stubs") ====================
    static void ShowBooksMenu()
    {
        Console.WriteLine("Aquí estará el menú de Libros.");
        Pause();
    }

    static void ShowUsersMenu()
    {
        Console.WriteLine("Aquí estará el menú de Usuarios.");
        Pause();
    }

    static void ShowLoansMenu()
    {
        Console.WriteLine("Aquí estará el menú de Préstamos.");
        Pause();
    }

    static void ShowSearchReportsMenu()
    {
        Console.WriteLine("Aquí estará el menú de Búsquedas y reportes.");
        Pause();
    }

    static void ShowPersistenceMenu()
    {
        Console.WriteLine("Aquí estará el menú de Guardar / Cargar datos.");
        Pause();
    }

    // ==================== UTILIDADES ====================

    // Lee una opción numérica. Si lo escrito no es un número, devuelve -1
    static int ReadOption(string mensaje)
    {
        Console.Write(mensaje);
        string entrada = Console.ReadLine();

        int opcion;
        if (int.TryParse(entrada, out opcion))
        {
            return opcion;
        }

        return -1;
    }

    // Detiene la pantalla hasta que el usuario presione Enter
    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
}