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

        // Una sola línea con lo más importante
    public string ResumenCorto()
    {
        return Id + " | " + Titulo + " | " + Autor;
    }

    // Sobrescribe el ToString() que ya trae todo objeto en C#
    public override string ToString()
    {
        return ResumenCorto();
    }
    
    // Todos los datos del libro, uno por línea
    public string DetalleCompleto()
    {
        string estado = "Prestado";
        if (Disponible)
        {
            estado = "Disponible";
        }

        return "ID: " + Id + "\n" +
               "Título: " + Titulo + "\n" +
               "Autor: " + Autor + "\n" +
               "Año: " + Anio + "\n" +
               "Categoría: " + Categoria + "\n" +
               "Estado: " + estado;
    }
}