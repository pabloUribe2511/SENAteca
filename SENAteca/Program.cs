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


    // ==================== MÓDULO LIBROS ====================
    static void ShowBooksMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("            MENÚ DE LIBROS");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Ver detalle de un libro");
            Console.WriteLine("4. Actualizar libro");
            Console.WriteLine("5. Eliminar libro");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine("------------------------------------");

            int opcion = ReadOption("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    RegisterBook();
                    break;
                case 2:
                    ListBooksMenu();
                    break;
                case 3:
                    ViewBookDetail();
                    break;
                case 4:
                    UpdateBookMenu();
                    break;
                case 5:
                    DeleteBook();
                    break;
                case 0:
                    volver = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Pause();
                    break;
            }
        }
    }

    static void RegisterBook()
    {
        Console.WriteLine("--- Registrar libro ---");
        Console.WriteLine("Aquí se registrará un nuevo libro (título, autor, año, categoría).");
        Pause();
    }

    static void ViewBookDetail()
    {
        Console.WriteLine("--- Ver detalle de libro ---");
        string id = ReadText("Ingrese el ID o ISBN del libro: ");
        Console.WriteLine("Aquí se mostrará el detalle del libro con ID/ISBN: " + id);
        Pause();
    }

    static void DeleteBook()
    {
        Console.WriteLine("--- Eliminar libro ---");
        Console.WriteLine("Validar no permitir si está prestado.");
        Pause();
    }

    // Stubs temporales (se completan en los siguientes commits)
    static void ListBooksMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("            LISTAR LIBROS");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Listar todos");
            Console.WriteLine("2. Listar disponibles");
            Console.WriteLine("3. Listar prestados");
            Console.WriteLine("0. Volver al menú de libros");
            Console.WriteLine("------------------------------------");

            int opcion = ReadOption("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    ListBooksAll();
                    break;
                case 2:
                    ListBooksAvailable();
                    break;
                case 3:
                    ListBooksBorrowed();
                    break;
                case 0:
                    volver = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Pause();
                    break;
            }
        }
    }

    static void ListBooksAll()
    {
        Console.WriteLine("--- Listar todos los libros ---");
        Console.WriteLine("Aquí se mostrarán todos los libros registrados.");
        Pause();
    }

    static void ListBooksAvailable()
    {
        Console.WriteLine("--- Listar libros disponibles ---");
        Console.WriteLine("Aquí se mostrarán los libros que están disponibles.");
        Pause();
    }

    static void ListBooksBorrowed()
    {
        Console.WriteLine("--- Listar libros prestados ---");
        Console.WriteLine("Aquí se mostrarán los libros que están prestados.");
        Pause();
    }
    
    static void UpdateBookMenu()
    {
        Console.WriteLine("Aquí estará el menú de actualizar libros.");
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

        // Pide un texto y repite la pregunta si el usuario no escribe nada
    static string ReadText(string mensaje)
    {
        string texto = "";

        while (texto.Trim() == "")
        {
            Console.Write(mensaje);
            texto = Console.ReadLine() ?? "";

            if (texto.Trim() == "")
            {
                Console.WriteLine("No puede estar vacío. Intente de nuevo.");
            }
        }

        return texto;
    }

    // Detiene la pantalla hasta que el usuario presione Enter
    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
}