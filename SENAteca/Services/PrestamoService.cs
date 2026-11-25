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
        // Busca un préstamo por su Id. Devuelve null si no existe
    public Prestamo? BuscarPorId(int id)
    {
        foreach (Prestamo prestamo in prestamos)
        {
            if (prestamo.Id == id)
            {
                return prestamo;
            }
        }
        return null;
    }

    // Elimina un préstamo de la lista
    public void EliminarPrestamo(Prestamo prestamo)
    {
        prestamos.Remove(prestamo);
    }

    // Marca como Vencido los préstamos activos cuya fecha límite ya pasó
    public void ActualizarEstados()
    {
        foreach (Prestamo prestamo in prestamos)
        {
            if (prestamo.Estado == EstadoPrestamo.Activo && prestamo.EstaVencido())
            {
                prestamo.Estado = EstadoPrestamo.Vencido;
            }
        }
    }
        // Devuelve los préstamos que tengan el estado indicado
    public List<Prestamo> BuscarPorEstado(EstadoPrestamo estado)
    {
        List<Prestamo> resultado = new List<Prestamo>();
        foreach (Prestamo prestamo in prestamos)
        {
            if (prestamo.Estado == estado)
            {
                resultado.Add(prestamo);
            }
        }
        return resultado;
    }
        // Devuelve una copia ordenada por fecha límite (la más próxima primero)
    public List<Prestamo> OrdenarPorFechaLimite()
    {
        List<Prestamo> copia = new List<Prestamo>(prestamos);
        copia.Sort((a, b) => a.FechaLimite.CompareTo(b.FechaLimite));
        return copia;
    }

    // ----- KPIs -----
    public int TotalPrestamos()
    {
        return prestamos.Count;
    }

    public int TotalActivos()
    {
        return BuscarPorEstado(EstadoPrestamo.Activo).Count;
    }

    public int TotalVencidos()
    {
        return BuscarPorEstado(EstadoPrestamo.Vencido).Count;
    }

    public int TotalDevueltos()
    {
        return BuscarPorEstado(EstadoPrestamo.Devuelto).Count;
    }

    // Promedio de días de todos los préstamos
    public double PromedioDiasPrestamo()
    {
        if (prestamos.Count == 0)
        {
            return 0;
        }

        int suma = 0;
        foreach (Prestamo prestamo in prestamos)
        {
            suma += prestamo.DiasTranscurridos();
        }

        return (double)suma / prestamos.Count;
    }
}