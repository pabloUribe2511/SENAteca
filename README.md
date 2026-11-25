# SENAteca

Proyecto de práctica en C# (consola) que simula el menú de un sistema de biblioteca.
Todas las opciones imprimen mensajes descriptivos. No usa POO, colecciones ni persistencia real.

## Menú principal

1. Libros
2. Usuarios
3. Préstamos
4. Búsquedas y reportes
5. Guardar / Cargar datos
6. Salir

## Cómo ejecutar

    cd SENAteca
    dotnet run

## Modelo de dominio (POO)

Carpeta `Models/`:

- `Libro.cs`
- `Usuario.cs`
- `Prestamo.cs`
- `EstadoPrestamo.cs` (enum: Activo, Devuelto, Vencido)

## Capa Services (List<T>)

Carpeta `Services/`:

- `LibroService.cs` → `List<Libro>`
- `UsuarioService.cs` → `List<Usuario>`
- `PrestamoService.cs` → `List<Prestamo>`

Cada servicio tiene: agregar, eliminar, buscar, ordenar y KPIs.

## Git Flow

- `main`: versión estable.
- `develop`: integración de los módulos.
- Ramas `feature/*`, creadas desde `develop` y fusionadas con `--no-ff`:
  - feature/project-bootstrap
  - feature/main-menu-navigation
  - feature/books-menu
  - feature/users-menu
  - feature/loans-menu
  - feature/search-reports-menu
  - feature/persistence-menu
  - feature/exit-flow

  Ramas nuevas:

- feature/models-libro
- feature/models-usuario
- feature/models-enum-estado-prestamo
- feature/models-prestamo
- feature/models-testing-objetos

Ramas nuevas:

- feature/services-setup
- feature/libro-service
- feature/usuario-service
- feature/prestamo-service
- feature/services-kpis
bash

## Autor

Juan Pablo Uribe