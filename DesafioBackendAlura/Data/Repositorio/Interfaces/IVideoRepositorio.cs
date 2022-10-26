using DesafioBackendAlura.Models;

namespace DesafioBackendAlura.Data.Repositorio.Interfaces
{
    public interface IVideoRepositorio
    {
        Task<Video> CriarVideo( Video video );
        Task<List<Video>> BuscarTodosVideos();
        Task<Video> BuscaVideoPorId( int id );
        Task<Video> AtualizarVideo( Video video );
        Task<bool> DeletarVideo( int id );
    }
}
