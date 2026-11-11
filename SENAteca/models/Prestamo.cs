public class Prestamo
{
    // Propiedades
    public int Id { get; set; }
    public int IdLibro { get; set; }
    public int IdUsuario { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaLimite { get; set; }
    public DateTime? FechaDevolucion { get; set; } = null;   // null = aún no se devuelve
    public EstadoPrestamo Estado { get; set; } = EstadoPrestamo.Activo;

    // Constructor vacío
    public Prestamo()
    {
        Estado = EstadoPrestamo.Activo;
        FechaDevolucion = null;
    }

    // Constructor completo
    public Prestamo(int id, int idLibro, int idUsuario, DateTime fechaPrestamo, DateTime fechaLimite)
    {
        Id = id;
        IdLibro = idLibro;
        IdUsuario = idUsuario;
        FechaPrestamo = fechaPrestamo;
        FechaLimite = fechaLimite;
        FechaDevolucion = null;
        Estado = EstadoPrestamo.Activo;
    }
}