public class Usuario
{
    // Propiedades
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string Documento { get; set; } = "";
    public string Contacto { get; set; } = "";
    public bool Activo { get; set; } = true;

    // Constructor vacío
    public Usuario()
    {
        Activo = true;
    }

    // Constructor completo
    public Usuario(int id, string nombre, string documento, string contacto)
    {
        Id = id;
        Nombre = nombre;
        Documento = documento;
        Contacto = contacto;
        Activo = true;
    }
        public string ResumenCorto()
    {
        return Id + " | " + Nombre + " | " + Documento;
    }

    public string DetalleCompleto()
    {
        string estado = "Inactivo";
        if (Activo)
        {
            estado = "Activo";
        }

        return "ID: " + Id + "\n" +
               "Nombre: " + Nombre + "\n" +
               "Documento: " + Documento + "\n" +
               "Contacto: " + Contacto + "\n" +
               "Estado: " + estado;
    }

    public override string ToString()
    {
        return ResumenCorto();
    }
}