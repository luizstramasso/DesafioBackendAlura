using DesafioBackendAlura.Models;

namespace DesafioBackendAlura.Servicos.Interfaces
{
    public interface IVideoServico
    {
        Task<Video> CriarVideo( Video video );
        Task<List<Video>> BuscarTodosVideos();
        Task<Video> BuscaVideoPorId( int id );
        Task<Video> AtualizarVideo( Video video );
        Task<bool> DeletarVideo( int id );
    }
}
