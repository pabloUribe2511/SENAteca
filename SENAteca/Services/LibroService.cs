public class LibroService
{
    // Lista que guarda todos los libros del sistema
    private List<Libro> libros = new List<Libro>();

    // Agrega un libro a la lista
    public void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
    }

    // Devuelve todos los libros
    public List<Libro> ObtenerTodos()
    {
        return libros;
    }
}