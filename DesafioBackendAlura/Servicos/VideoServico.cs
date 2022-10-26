using DesafioBackendAlura.Data.Repositorio.Interfaces;
using DesafioBackendAlura.Models;
using DesafioBackendAlura.Servicos.Interfaces;

namespace DesafioBackendAlura.Servicos
{
    public class VideoServico : IVideoServico
    {
        private readonly IVideoRepositorio _repositorio;
        public VideoServico( IVideoRepositorio repositorio )
        {
            _repositorio = repositorio;
        }

        public async Task<Video> AtualizarVideo( Video video )
        {
            return await _repositorio.AtualizarVideo( video );
        }

        public async Task<List<Video>> BuscarTodosVideos()
        {
            return await _repositorio.BuscarTodosVideos();
        }

        public async Task<Video> BuscaVideoPorId( int id )
        {
            return await _repositorio.BuscaVideoPorId( id );
        }

        public async Task<Video> CriarVideo( Video video )
        {
            return await _repositorio.CriarVideo( video );
        }

        public async Task<bool> DeletarVideo( int id )
        {
            return await _repositorio.DeletarVideo( id );
        }
    }
}
