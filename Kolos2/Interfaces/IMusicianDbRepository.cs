using System;

public interface IMusicianDbRepository
{
	Task<MusicianResponseDTO> GetMusicianFromDbAsync(int id);
}
