public class UsuarioService
{
    // Lista que guarda todos los usuarios del sistema
    private List<Usuario> usuarios = new List<Usuario>();

    // Agrega un usuario a la lista
    public void AgregarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
    }

    // Devuelve todos los usuarios
    public List<Usuario> ObtenerTodos()
    {
        return usuarios;
    }
        // Busca un usuario por su Id. Devuelve null si no existe
    public Usuario? BuscarPorId(int id)
    {
        foreach (Usuario usuario in usuarios)
        {
            if (usuario.Id == id)
            {
                return usuario;
            }
        }
        return null;
    }

    // Elimina un usuario de la lista
    public void EliminarUsuario(Usuario usuario)
    {
        usuarios.Remove(usuario);
    }
        // Busca un usuario por documento exacto
    public Usuario? BuscarPorDocumento(string documento)
    {
        foreach (Usuario usuario in usuarios)
        {
            if (usuario.Documento == documento)
            {
                return usuario;
            }
        }
        return null;
    }

    // Busca usuarios cuyo nombre contenga el texto (sin importar mayúsculas)
    public List<Usuario> BuscarPorNombre(string texto)
    {
        List<Usuario> resultado = new List<Usuario>();
        foreach (Usuario usuario in usuarios)
        {
            if (usuario.Nombre.ToLower().Contains(texto.ToLower()))
            {
                resultado.Add(usuario);
            }
        }
        return resultado;
    }
}