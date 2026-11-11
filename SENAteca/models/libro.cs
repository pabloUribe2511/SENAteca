public class Libro
{
    // Propiedades
    public int Id { get; set; }
    public string Titulo { get; set; } = "";
    public string Autor { get; set; } = "";
    public int Anio { get; set; }
    public string Categoria { get; set; } = "";
    public bool Disponible { get; set; } = true;

    // Constructor vacío
    public Libro()
    {
        Disponible = true;
    }

    // Constructor completo
    public Libro(int id, string titulo, string autor, int anio, string categoria)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
        Anio = anio;
        Categoria = categoria;
        Disponible = true;
    }
}