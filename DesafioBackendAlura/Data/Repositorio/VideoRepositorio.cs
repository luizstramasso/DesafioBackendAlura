using DesafioBackendAlura.Data.Repositorio.Interfaces;
using DesafioBackendAlura.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioBackendAlura.Data.Repositorio
{
    public class VideoRepositorio : IVideoRepositorio
    {
        private readonly DesafioBackendAluraContext _context;

        public VideoRepositorio( DesafioBackendAluraContext context )
        {
            _context = context;
        }

        public async Task<Video> AtualizarVideo( Video video )
        {
            _context.Update( video );
            await _context.SaveChangesAsync();
            return video;
        }

        public async Task<List<Video>> BuscarTodosVideos()
        {
            return await _context.Videos.ToListAsync();
        }

        public async Task<Video> BuscaVideoPorId( int id )
        {
            return await _context.Videos.FirstOrDefaultAsync( x => x.Id == id );
        }

        public async Task<Video> CriarVideo( Video video )
        {
            await _context.AddAsync( video );
            await _context.SaveChangesAsync();

            return video;
        }

        public async Task<bool> DeletarVideo( int id )
        {
            var video = await _context.Videos.FirstOrDefaultAsync( x => x.Id == id );
            if( video == default )
            {
                return false;
            }
            _context.Remove( video );
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
