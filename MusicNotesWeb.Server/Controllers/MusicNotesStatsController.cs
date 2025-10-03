using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MusicNotesWeb.Entity.models;

namespace MusicNotesWeb.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicNotesStatsController : ControllerBase
    {

        private readonly ILogger<MusicNotesStatsController> _logger;
        private readonly IMusicNotesRepository _musicNotesRepository;
        private readonly IMapper _map;

        public MusicNotesStatsController(ILogger<MusicNotesStatsController> logger, IMusicNotesRepository musicNotesRepository, IMapper map)
        {
            _logger = logger;
            this._musicNotesRepository = musicNotesRepository;
            this._map = map;
        }

        [HttpGet(Name = "gameDetails")]
        //[Route("api/gameDetails")]
        public async Task<IEnumerable<GameDetails>> Get()
        {
            //throw new NotImplementedException();
            return await _musicNotesRepository.GetAll();
        }

        [HttpPost]
        [Route("createGameDetails")]
        public async Task<IActionResult> CreateGameDetails([FromBody] CreateGameDetailsContract createGameDetails)
        {
            if (createGameDetails == null)
            {
                return BadRequest();
            }
            var gameDts = _map.Map<CreateGameDetailsContract, GameDetails>(createGameDetails);

            var result = await _musicNotesRepository.CreateGameDetails(gameDts);
            return Ok();
        }
    }
}
