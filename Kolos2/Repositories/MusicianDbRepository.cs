using System;

public class MusicianDbRepository : IMusicianDbRepository
{
	private readonly MusicianContext _context;
	public MusicianDbRepository(MusicianContext context)
    {
        _context = context;
    }

    public async Task<MusicianResponseDTO> GetMusicianDromDbAsync(int id)
    {
        var res =await _context.Musucian.Include(x => x.MusicianTrack)
            .ThenInclude(x => x.Duration).Where(x => x.IdMusician==id)
            .Select(x=> new MusicianResponseDTO)
            { 
        }

    }
}
