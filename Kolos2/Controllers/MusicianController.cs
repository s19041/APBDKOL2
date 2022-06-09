using System;
[Route("api/musicians")]
[ApiController]
[Authorize]
public class MusicianController : ControllerBase
{
	private readonly IMusicianDbRepository _musicianDbRepository;
	public MusicianController(IMusicianDbRepository musicianDbRepository)
	{
		_musicianDbRepository = musicianDbRepository;
	}

	[HttpGet("{idMusician}")]
	public async Task<IActionResult> GetMusician([FromRoute] string idMusician)
    {
        int id;
        if (!int.TryParse(idMusician, out id))
            return BadRequest();
        var result = await _musicianDbRepository.GetMusicianFromDbAsync(id);
        if (result == null)
            return NotFound();
        return Ok(result);
    }

    [HttpDelete("{idMusician}")]
    public async Task<IActionResult> DeleteMusician([FromRoute] string idMusician)
    {
        int id;
        if (!int.TryParse(idMusician, out id))
            return BadRequest();
        var result = await _musicianDbRepository.DeleteMusucianInDbAsync(id);
        if (result)
            return NoContent();
        return NotFound();
    }
}
