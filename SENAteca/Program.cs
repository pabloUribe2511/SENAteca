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
                    ConfirmExitAndSave();
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
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("           ACTUALIZAR LIBRO");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Editar título");
            Console.WriteLine("2. Editar autor");
            Console.WriteLine("3. Editar año / categoría");
            Console.WriteLine("0. Volver al menú de libros");
            Console.WriteLine("------------------------------------");

            int opcion = ReadOption("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    EditBookTitle();
                    break;
                case 2:
                    EditBookAuthor();
                    break;
                case 3:
                    EditBookYearCategory();
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

    static void EditBookTitle()
    {
        Console.WriteLine("--- Editar título ---");
        Console.WriteLine("Aquí se editará el título del libro seleccionado.");
        Pause();
    }

    static void EditBookAuthor()
    {
        Console.WriteLine("--- Editar autor ---");
        Console.WriteLine("Aquí se editará el autor del libro seleccionado.");
        Pause();
    }

    static void EditBookYearCategory()
    {
        Console.WriteLine("--- Editar año / categoría ---");
        Console.WriteLine("Aquí se editará el año y la categoría del libro seleccionado.");
        Pause();
    }

       // ==================== MÓDULO USUARIOS ====================
    static void ShowUsersMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("          MENÚ DE USUARIOS");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Registrar usuario");
            Console.WriteLine("2. Listar usuarios");
            Console.WriteLine("3. Ver detalle de un usuario");
            Console.WriteLine("4. Actualizar usuario");
            Console.WriteLine("5. Eliminar usuario");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine("------------------------------------");

            int opcion = ReadOption("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    RegisterUser();
                    break;
                case 2:
                    ListUsers();
                    break;
                case 3:
                    ViewUserDetail();
                    break;
                case 4:
                    UpdateUserMenu();
                    break;
                case 5:
                    DeleteUser();
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

    static void RegisterUser()
    {
        Console.WriteLine("--- Registrar usuario ---");
        Console.WriteLine("Aquí se registrará un nuevo usuario (nombre, documento, contacto).");
        Pause();
    }

    static void ListUsers()
    {
        Console.WriteLine("--- Listar usuarios ---");
        Console.WriteLine("Aquí se mostrarán todos los usuarios registrados.");
        Pause();
    }

    static void ViewUserDetail()
    {
        Console.WriteLine("--- Ver detalle de usuario ---");
        string id = ReadText("Ingrese el ID o documento del usuario: ");
        Console.WriteLine("Aquí se mostrará el detalle del usuario con ID/documento: " + id);
        Pause();
    }

    // Stubs temporales (se completan en los siguientes commits)
       static void UpdateUserMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("          ACTUALIZAR USUARIO");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Editar nombre");
            Console.WriteLine("2. Editar contacto");
            Console.WriteLine("3. Activar / desactivar");
            Console.WriteLine("0. Volver al menú de usuarios");
            Console.WriteLine("------------------------------------");

            int opcion = ReadOption("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    EditUserName();
                    break;
                case 2:
                    EditUserContact();
                    break;
                case 3:
                    ToggleUserActiveStatus();
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

    static void EditUserName()
    {
        Console.WriteLine("--- Editar nombre ---");
        Console.WriteLine("Aquí se editará el nombre del usuario seleccionado.");
        Pause();
    }

    static void EditUserContact()
    {
        Console.WriteLine("--- Editar contacto ---");
        Console.WriteLine("Aquí se editará el contacto del usuario seleccionado.");
        Pause();
    }

    static void ToggleUserActiveStatus()
    {
        Console.WriteLine("--- Activar / desactivar usuario ---");
        Console.WriteLine("Aquí se cambiará el estado del usuario (activo o inactivo).");
        Pause();
    }


    static void DeleteUser()
    {
        Console.WriteLine("--- Eliminar usuario ---");
        Console.WriteLine("Validar no permitir si tiene préstamos activos.");
        Pause();
    }


    // ==================== MÓDULO PRÉSTAMOS ====================
    static void ShowLoansMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("         MENÚ DE PRÉSTAMOS");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Crear préstamo");
            Console.WriteLine("2. Listar préstamos");
            Console.WriteLine("3. Ver detalle de un préstamo");
            Console.WriteLine("4. Registrar devolución");
            Console.WriteLine("5. Eliminar préstamo");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine("------------------------------------");

            int opcion = ReadOption("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    CreateLoan();
                    break;
                case 2:
                    ListLoansMenu();
                    break;
                case 3:
                    ViewLoanDetail();
                    break;
                case 4:
                    RegisterReturn();
                    break;
                case 5:
                    DeleteLoan();
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

    static void CreateLoan()
    {
        Console.WriteLine("--- Crear préstamo ---");
        Console.WriteLine("Aquí se creará un nuevo préstamo.");
        Console.WriteLine();
        Console.WriteLine("Validaciones sugeridas:");
        Console.WriteLine("- El libro debe existir.");
        Console.WriteLine("- El libro debe estar disponible.");
        Console.WriteLine("- El usuario debe existir.");
        Console.WriteLine("- El usuario debe estar activo.");
        Console.WriteLine("- El usuario no debe tener préstamos vencidos.");
        Console.WriteLine("- La fecha de devolución debe ser posterior a la fecha de préstamo.");
        Pause();
    }

    // Stubs temporales (se completan en los siguientes commits)
    static void ListLoansMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("          LISTAR PRÉSTAMOS");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Todos");
            Console.WriteLine("2. Activos");
            Console.WriteLine("3. Cerrados");
            Console.WriteLine("0. Volver al menú de préstamos");
            Console.WriteLine("------------------------------------");

            int opcion = ReadOption("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    ListLoansAll();
                    break;
                case 2:
                    ListLoansActive();
                    break;
                case 3:
                    ListLoansClosed();
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

    static void ListLoansAll()
    {
        Console.WriteLine("--- Listar todos los préstamos ---");
        Console.WriteLine("Aquí se mostrarán todos los préstamos registrados.");
        Pause();
    }

    static void ListLoansActive()
    {
        Console.WriteLine("--- Listar préstamos activos ---");
        Console.WriteLine("Aquí se mostrarán los préstamos que aún no han sido devueltos.");
        Pause();
    }

    static void ListLoansClosed()
    {
        Console.WriteLine("--- Listar préstamos cerrados ---");
        Console.WriteLine("Aquí se mostrarán los préstamos que ya fueron devueltos.");
        Pause();
    }

    static void ViewLoanDetail()
    {
        Console.WriteLine("--- Ver detalle de préstamo ---");
        string id = ReadText("Ingrese el ID del préstamo: ");
        Console.WriteLine("Aquí se mostrará el detalle del préstamo con ID: " + id);
        Pause();
    }

    static void RegisterReturn()
    {
        Console.WriteLine("--- Registrar devolución ---");
        string id = ReadText("Ingrese el ID del préstamo: ");
        Console.WriteLine("Aquí se marcará el préstamo " + id + " como devuelto.");
        Console.WriteLine("Además, el libro volverá a estar disponible.");
        Pause();
    }

    static void DeleteLoan()
    {
        Console.WriteLine("--- Eliminar préstamo ---");
        Console.WriteLine("Reglas sugeridas:");
        Console.WriteLine("- No permitir eliminar un préstamo que siga activo.");
        Console.WriteLine("- Solo se pueden eliminar préstamos cerrados (ya devueltos).");
        Console.WriteLine("- Pedir confirmación antes de eliminar.");
        Pause();
    }
      // ==================== MÓDULO BÚSQUEDAS Y REPORTES ====================
    static void ShowSearchReportsMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("       BÚSQUEDAS Y REPORTES");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Buscar libro");
            Console.WriteLine("2. Buscar usuario");
            Console.WriteLine("3. Reportes");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine("------------------------------------");

            int opcion = ReadOption("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    SearchBook();
                    break;
                case 2:
                    SearchUser();
                    break;
                case 3:
                    ReportsMenu();
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

    static void SearchBook()
    {
        Console.WriteLine("--- Buscar libro ---");
        Console.WriteLine("Se podrá buscar por: título, autor, ID o categoría.");
        string texto = ReadText("Ingrese el texto a buscar: ");
        Console.WriteLine("Aquí se mostrarán los libros que coincidan con: " + texto);
        Pause();
    }

    static void SearchUser()
    {
        Console.WriteLine("--- Buscar usuario ---");
        Console.WriteLine("Se podrá buscar por: nombre o ID.");
        string texto = ReadText("Ingrese el texto a buscar: ");
        Console.WriteLine("Aquí se mostrarán los usuarios que coincidan con: " + texto);
        Pause();
    }

    // Stub temporal (se completa en el siguiente commit)
     static void ReportsMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("              REPORTES");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Reporte por usuario");
            Console.WriteLine("2. Reporte por libro");
            Console.WriteLine("3. Reporte de préstamos vencidos");
            Console.WriteLine("4. Resumen general");
            Console.WriteLine("0. Volver a búsquedas y reportes");
            Console.WriteLine("------------------------------------");

            int opcion = ReadOption("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    ReportByUser();
                    break;
                case 2:
                    ReportByBook();
                    break;
                case 3:
                    ReportOverdue();
                    break;
                case 4:
                    ReportSummary();
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

    static void ReportByUser()
    {
        Console.WriteLine("--- Reporte por usuario ---");
        string id = ReadText("Ingrese el ID o documento del usuario: ");
        Console.WriteLine("Aquí se mostrarán los préstamos del usuario: " + id);
        Pause();
    }

    static void ReportByBook()
    {
        Console.WriteLine("--- Reporte por libro ---");
        string id = ReadText("Ingrese el ID o ISBN del libro: ");
        Console.WriteLine("Aquí se mostrará el historial de préstamos del libro: " + id);
        Pause();
    }

    static void ReportOverdue()
    {
        Console.WriteLine("--- Reporte de préstamos vencidos ---");
        Console.WriteLine("Aquí se mostrarán los préstamos cuya fecha de devolución ya pasó.");
        Pause();
    }

    static void ReportSummary()
    {
        Console.WriteLine("--- Resumen general ---");
        Console.WriteLine("Aquí se mostrará el resumen: total de libros, usuarios y préstamos activos.");
        Pause();
    }

    // ==================== MÓDULO GUARDAR / CARGAR DATOS ====================
    static void ShowPersistenceMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("        GUARDAR / CARGAR DATOS");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Guardar datos");
            Console.WriteLine("2. Cargar datos");
            Console.WriteLine("3. Reiniciar datos");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine("------------------------------------");

            int opcion = ReadOption("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    SaveData();
                    break;
                case 2:
                    LoadData();
                    break;
                case 3:
                    ResetData();
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

        // ==================== SALIR ====================
    // Pregunta si desea guardar antes de salir (S/N)
    static void ConfirmExitAndSave()
    {
        Console.WriteLine("--- Salir ---");

        if (ReadYesNo("¿Guardar antes de salir? (S/N): "))
        {
            SaveData();
        }
        else
        {
            Console.WriteLine("Los datos no se guardaron.");
        }

        Console.WriteLine("Saliendo de SENAteca... ¡Hasta pronto!");
    }

    static void SaveData()
    {
        Console.WriteLine("--- Guardar datos ---");
        Console.WriteLine("Aquí se guardarán los datos de libros, usuarios y préstamos.");
        Pause();
    }

    static void LoadData()
    {
        Console.WriteLine("--- Cargar datos ---");
        Console.WriteLine("Aquí se cargarán los datos de libros, usuarios y préstamos guardados.");
        Pause();
    }

    // Stub temporal (se completa en el siguiente commit)
    // Pregunta S/N y devuelve true si el usuario confirma
    static bool ConfirmResetData()
    {
        Console.WriteLine("Esta acción eliminará todos los datos guardados.");
        return ReadYesNo("¿Está seguro de reiniciar los datos? (S/N): ");
    }

    static void ResetData()
    {
        Console.WriteLine("--- Reiniciar datos ---");

        if (ConfirmResetData())
        {
            Console.WriteLine("Aquí se reiniciarán todos los datos del sistema.");
        }
        else
        {
            Console.WriteLine("Operación cancelada. No se reiniciaron los datos.");
        }

        Pause();
    }
    // ==================== OBJETOS DE PRUEBA ====================
    // Cada función devuelve un objeto de prueba (2 libros, 2 usuarios, 1 préstamo)
    static Libro CreateSampleBook1()
    {
        return new Libro(1, "Cien años de soledad", "Gabriel García Márquez", 1967, "Novela");
    }

    static Libro CreateSampleBook2()
    {
        Libro libro = new Libro(2, "El principito", "Antoine de Saint-Exupéry", 1943, "Fábula");
        libro.Disponible = false;   // este libro está prestado
        return libro;
    }

    static Usuario CreateSampleUser1()
    {
        return new Usuario(1, "Juan Pablo Uribe", "1001234567", "juan@correo.com");
    }

    static Usuario CreateSampleUser2()
    {
        Usuario usuario = new Usuario(2, "María Gómez", "1007654321", "maria@correo.com");
        usuario.Activo = false;   // este usuario está inactivo
        return usuario;
    }

    static Prestamo CreateSampleLoan()
    {
        DateTime hoy = DateTime.Now;
        // Préstamo del libro 2 al usuario 1: hace 5 días, con límite en 2 días
        return new Prestamo(1, 2, 1, hoy.AddDays(-5), hoy.AddDays(2));
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

        // Pregunta S/N y repite hasta que escriban S o N. Devuelve true si es S
    static bool ReadYesNo(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string respuesta = (Console.ReadLine() ?? "").Trim().ToUpper();

            if (respuesta == "S")
            {
                return true;
            }
            else if (respuesta == "N")
            {
                return false;
            }

            Console.WriteLine("Respuesta no válida. Escriba S o N.");
        }
    }

    // Detiene la pantalla hasta que el usuario presione Enter
    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
}