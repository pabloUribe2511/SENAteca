using System;

class Program

{
        // Instancias de los servicios (se crean una sola vez)
    static LibroService libroService = new LibroService();
    static UsuarioService usuarioService = new UsuarioService();
    static PrestamoService prestamoService = new PrestamoService();

    static void Main(string[] args)
    {
        // Permite mostrar tildes y ñ correctamente en la consola
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        LoadSampleData();
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
        int id = ReadOption("Ingrese el ID del libro: ");
        Libro? libro = libroService.BuscarPorId(id);

        if (libro != null)
        {
            Console.WriteLine(libro.DetalleCompleto());
            Console.WriteLine("¿Disponible?: " + libro.Disponible);
            Console.WriteLine("ToString(): " + libro.ToString());
        }
        else
        {
            Console.WriteLine("No se encontró un libro con el ID: " + id);
        }
        Pause();
    }

    static void DeleteBook()
    {
        Console.WriteLine("--- Eliminar libro ---");
        int id = ReadOption("Ingrese el ID del libro a eliminar: ");
        Libro? libro = libroService.BuscarPorId(id);

        if (libro == null)
        {
            Console.WriteLine("No se encontró un libro con el ID: " + id);
        }
        else if (!libro.Disponible)
        {
            Console.WriteLine("No se puede eliminar: el libro está prestado.");
        }
        else
        {
            libroService.EliminarLibro(libro);
            Console.WriteLine("Libro eliminado: " + libro.Titulo);
        }
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
        PrintBooks(libroService.ObtenerTodos());
        Pause();
    }

    static void ListBooksAvailable()
    {
        Console.WriteLine("--- Listar libros disponibles ---");
        PrintBooks(libroService.ObtenerDisponibles());
        Pause();
    }

    static void ListBooksBorrowed()
    {
        Console.WriteLine("--- Listar libros prestados ---");
        PrintBooks(libroService.ObtenerPrestados());
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
        PrintUsers(usuarioService.ObtenerTodos());
        Pause();
    }

    static void ViewUserDetail()
    {
        Console.WriteLine("--- Ver detalle de usuario ---");
        int id = ReadOption("Ingrese el ID del usuario: ");
        Usuario? usuario = usuarioService.BuscarPorId(id);

        if (usuario != null)
        {
            Console.WriteLine(usuario.DetalleCompleto());
            Console.WriteLine("¿Activo?: " + usuario.Activo);
            Console.WriteLine("ToString(): " + usuario.ToString());
        }
        else
        {
            Console.WriteLine("No se encontró un usuario con el ID: " + id);
        }
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
        int id = ReadOption("Ingrese el ID del usuario a eliminar: ");
        Usuario? usuario = usuarioService.BuscarPorId(id);

        if (usuario == null)
        {
            Console.WriteLine("No se encontró un usuario con el ID: " + id);
        }
        else
        {
            // Regla: no se puede eliminar si tiene préstamos que no ha devuelto
            bool tienePrestamosActivos = false;
            foreach (Prestamo prestamo in prestamoService.ObtenerTodos())
            {
                if (prestamo.IdUsuario == usuario.Id && prestamo.Estado != EstadoPrestamo.Devuelto)
                {
                    tienePrestamosActivos = true;
                }
            }

            if (tienePrestamosActivos)
            {
                Console.WriteLine("No se puede eliminar: el usuario tiene préstamos activos.");
            }
            else
            {
                usuarioService.EliminarUsuario(usuario);
                Console.WriteLine("Usuario eliminado: " + usuario.Nombre);
            }
        }
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
        Prestamo prestamo = CreateSampleLoan();

        Console.WriteLine("--- Listar todos los préstamos ---");
        Console.WriteLine(prestamo.ResumenCorto());
        Pause();
    }

    static void ListLoansActive()
    {
        Prestamo prestamo = CreateSampleLoan();

        Console.WriteLine("--- Listar préstamos activos ---");

        if (prestamo.Estado == EstadoPrestamo.Activo)
        {
            Console.WriteLine(prestamo.ResumenCorto());
        }
        else
        {
            Console.WriteLine("No hay préstamos activos.");
        }
        Pause();
    }

     static void ListLoansClosed()
    {
        Prestamo prestamo = CreateSampleLoan();

        Console.WriteLine("--- Listar préstamos cerrados ---");

        if (prestamo.Estado == EstadoPrestamo.Devuelto)
        {
            Console.WriteLine(prestamo.ResumenCorto());
        }
        else
        {
            Console.WriteLine("No hay préstamos cerrados.");
        }
        Pause();
    }

    static void ViewLoanDetail()
    {
        Console.WriteLine("--- Ver detalle de préstamo ---");
        string id = ReadText("Ingrese el ID del préstamo (1): ");

        if (id == "1")
        {
            Prestamo prestamo = CreateSampleLoan();
            Console.WriteLine(prestamo.DetalleCompleto());
            Console.WriteLine();
            Console.WriteLine("Estado: " + prestamo.Estado);
            Console.WriteLine("¿Está vencido?: " + prestamo.EstaVencido());
            Console.WriteLine("Días transcurridos: " + prestamo.DiasTranscurridos());
            Console.WriteLine("ToString(): " + prestamo.ToString());
        }
        else
        {
            Console.WriteLine("No se encontró un préstamo con el ID: " + id);
        }
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
        string texto = ReadText("Ingrese ISBN, título o autor a buscar: ");

        Console.WriteLine();
        Console.WriteLine("Resultado por ISBN:");
        Libro? porIsbn = libroService.BuscarPorIsbn(texto);
        if (porIsbn != null)
        {
            Console.WriteLine(porIsbn.ResumenCorto());
        }
        else
        {
            Console.WriteLine("No hay libros para mostrar.");
        }

        Console.WriteLine();
        Console.WriteLine("Resultados por título:");
        PrintBooks(libroService.BuscarPorTitulo(texto));

        Console.WriteLine();
        Console.WriteLine("Resultados por autor:");
        PrintBooks(libroService.BuscarPorAutor(texto));

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
            Console.WriteLine("5. Comparación Array vs List");
            Console.WriteLine("6. Listados ordenados");
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
                case 5:
                    ShowArrayVsListDemo();
                    break;
                case 6:
                    ShowSortedLists();
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
        // Comparación entre un array y una List
    static void ShowArrayVsListDemo()
    {
        Console.WriteLine("--- Comparación Array vs List ---");
        Console.WriteLine();

        // ARRAY: el tamaño se define al crearlo y no cambia
        string[] titulosArray = new string[3];
        titulosArray[0] = "Cien años de soledad";
        titulosArray[1] = "El principito";
        titulosArray[2] = "Rayuela";
        // titulosArray[3] = "Don Quijote";   // ERROR: el array solo tiene 3 posiciones

        Console.WriteLine("ARRAY (tamaño fijo = " + titulosArray.Length + "):");
        for (int i = 0; i < titulosArray.Length; i++)
        {
            Console.WriteLine("  " + titulosArray[i]);
        }

        // LIST: el tamaño crece y se reduce solo
        List<string> titulosList = new List<string>();
        titulosList.Add("Cien años de soledad");
        titulosList.Add("El principito");
        titulosList.Add("Rayuela");
        titulosList.Add("Don Quijote");        // se puede agregar sin problema
        titulosList.Remove("El principito");   // y también eliminar

        Console.WriteLine();
        Console.WriteLine("LIST (tamaño dinámico, Count = " + titulosList.Count + "):");
        foreach (string titulo in titulosList)
        {
            Console.WriteLine("  " + titulo);
        }

        Console.WriteLine();
        Console.WriteLine("DIFERENCIAS:");
        Console.WriteLine("- Array: tamaño fijo. Para agregar uno más hay que crear otro array y copiar todo.");
        Console.WriteLine("- List: tamaño dinámico. Tiene Add, Remove, Sort, Contains, etc.");
        Console.WriteLine("- Array se usa con .Length y List con .Count.");
        Console.WriteLine("Por eso los servicios usan List<T>: los libros, usuarios y préstamos cambian todo el tiempo.");
        Pause();
    }

    // Listados ordenados (se completa en las siguientes ramas)
    static void ShowSortedLists()
    {
        Console.WriteLine("--- Listados ordenados ---");

        Console.WriteLine();
        Console.WriteLine("Libros ordenados por título:");
        PrintBooks(libroService.OrdenarPorTitulo());

        Console.WriteLine();
        Console.WriteLine("Libros ordenados por año:");
        PrintBooks(libroService.OrdenarPorAnio());

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
        // ==================== DATOS DE PRUEBA PARA LOS SERVICIOS ====================
    static void LoadSampleData()
    {
        DateTime hoy = DateTime.Now;

        // ----- Libros -----
        Libro libro1 = new Libro(1, "Cien años de soledad", "Gabriel García Márquez", 1967, "Novela");
        libro1.Isbn = "978-0001";
        Libro libro2 = new Libro(2, "El principito", "Antoine de Saint-Exupéry", 1943, "Fábula");
        libro2.Isbn = "978-0002";
        libro2.Disponible = false;   // prestado
        Libro libro3 = new Libro(3, "Don Quijote de la Mancha", "Miguel de Cervantes", 1605, "Novela");
        libro3.Isbn = "978-0003";
        Libro libro4 = new Libro(4, "Rayuela", "Julio Cortázar", 1963, "Novela");
        libro4.Isbn = "978-0004";
        libro4.Disponible = false;   // prestado
        Libro libro5 = new Libro(5, "El amor en los tiempos del cólera", "Gabriel García Márquez", 1985, "Novela");
        libro5.Isbn = "978-0005";

        libroService.AgregarLibro(libro1);
        libroService.AgregarLibro(libro2);
        libroService.AgregarLibro(libro3);
        libroService.AgregarLibro(libro4);
        libroService.AgregarLibro(libro5);

        // ----- Usuarios -----
        Usuario usuario1 = new Usuario(1, "Juan Pablo Uribe", "1001234567", "juan@correo.com");
        Usuario usuario2 = new Usuario(2, "María Gómez", "1007654321", "maria@correo.com");
        usuario2.Activo = false;   // inactivo
        Usuario usuario3 = new Usuario(3, "Carlos Pérez", "1009998887", "carlos@correo.com");

        usuarioService.AgregarUsuario(usuario1);
        usuarioService.AgregarUsuario(usuario2);
        usuarioService.AgregarUsuario(usuario3);

        // ----- Préstamos -----
        // Activo: libro 2 al usuario 1, hace 5 días, límite en 2 días
        Prestamo prestamo1 = new Prestamo(1, 2, 1, hoy.AddDays(-5), hoy.AddDays(2));

        // Vencido: libro 4 al usuario 3, hace 20 días, el límite fue hace 6 días
        Prestamo prestamo2 = new Prestamo(2, 4, 3, hoy.AddDays(-20), hoy.AddDays(-6));

        // Devuelto: libro 1 al usuario 2, devuelto hace 20 días
        Prestamo prestamo3 = new Prestamo(3, 1, 2, hoy.AddDays(-30), hoy.AddDays(-16));
        prestamo3.Estado = EstadoPrestamo.Devuelto;
        prestamo3.FechaDevolucion = hoy.AddDays(-20);

        prestamoService.AgregarPrestamo(prestamo1);
        prestamoService.AgregarPrestamo(prestamo2);
        prestamoService.AgregarPrestamo(prestamo3);
    }

    // ==================== OBJETOS DE PRUEBA ====================

    static Prestamo CreateSampleLoan()
    {
        DateTime hoy = DateTime.Now;
        // Préstamo del libro 2 al usuario 1: hace 5 días, con límite en 2 días
        return new Prestamo(1, 2, 1, hoy.AddDays(-5), hoy.AddDays(2));
    }
    
        // ==================== MOSTRAR LISTAS ====================
    static void PrintBooks(List<Libro> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("No hay libros para mostrar.");
        }

        foreach (Libro libro in lista)
        {
            Console.WriteLine(libro.ResumenCorto());
        }
    }
    static void PrintUsers(List<Usuario> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("No hay usuarios para mostrar.");
        }

        foreach (Usuario usuario in lista)
        {
            Console.WriteLine(usuario.ResumenCorto());
        }
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