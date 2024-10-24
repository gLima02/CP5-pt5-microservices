using web_app_domain;

namespace web_app_repository
    //necessario colocar os métodos criados na repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> ListarUsuarios();
        Task SalvarUsuario(Usuario usuario);
        Task AtualizarUsuario(Usuario usuario);
        Task RemoverUsuario(int id);
    }
}