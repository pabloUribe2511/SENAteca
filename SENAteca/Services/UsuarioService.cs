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
}