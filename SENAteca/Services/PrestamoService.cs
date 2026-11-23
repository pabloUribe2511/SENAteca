public class PrestamoService
{
    // Lista que guarda todos los préstamos del sistema
    private List<Prestamo> prestamos = new List<Prestamo>();

    // Agrega un préstamo a la lista
    public void AgregarPrestamo(Prestamo prestamo)
    {
        prestamos.Add(prestamo);
    }

    // Devuelve todos los préstamos
    public List<Prestamo> ObtenerTodos()
    {
        return prestamos;
    }
}