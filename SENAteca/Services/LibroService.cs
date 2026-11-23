public class LibroService
{
    // Lista que guarda todos los libros del sistema
    private List<Libro> libros = new List<Libro>();

    // Agrega un libro a la lista
    public void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
    }
    
    // Busca un libro por su Id. Devuelve null si no existe (por eso el "?")
    public Libro? BuscarPorId(int id)
    {
        foreach (Libro libro in libros)
        {
            if (libro.Id == id)
            {
                return libro;
            }
        }
        return null;
    }

    // Elimina un libro de la lista
    public void EliminarLibro(Libro libro)
    {
        libros.Remove(libro);
    }

    // Devuelve solo los libros disponibles
    public List<Libro> ObtenerDisponibles()
    {
        List<Libro> resultado = new List<Libro>();
        foreach (Libro libro in libros)
        {
            if (libro.Disponible)
            {
                resultado.Add(libro);
            }
        }
        return resultado;
    }

    // Devuelve solo los libros prestados
    public List<Libro> ObtenerPrestados()
    {
        List<Libro> resultado = new List<Libro>();
        foreach (Libro libro in libros)
        {
            if (!libro.Disponible)
            {
                resultado.Add(libro);
            }
        }
        return resultado;
    }
    // Devuelve todos los libros
    public List<Libro> ObtenerTodos()
    {
        return libros;
    }
        // Busca un libro por ISBN exacto
    public Libro? BuscarPorIsbn(string isbn)
    {
        foreach (Libro libro in libros)
        {
            if (libro.Isbn == isbn)
            {
                return libro;
            }
        }
        return null;
    }

    // Busca libros cuyo título contenga el texto (sin importar mayúsculas)
    public List<Libro> BuscarPorTitulo(string texto)
    {
        List<Libro> resultado = new List<Libro>();
        foreach (Libro libro in libros)
        {
            if (libro.Titulo.ToLower().Contains(texto.ToLower()))
            {
                resultado.Add(libro);
            }
        }
        return resultado;
    }

    // Busca libros cuyo autor contenga el texto (sin importar mayúsculas)
    public List<Libro> BuscarPorAutor(string texto)
    {
        List<Libro> resultado = new List<Libro>();
        foreach (Libro libro in libros)
        {
            if (libro.Autor.ToLower().Contains(texto.ToLower()))
            {
                resultado.Add(libro);
            }
        }
        return resultado;
    }
}