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
}