using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicNotesWeb.Entity.models
{
    public interface IMusicNotesRepository
    {
        Task<bool> CreateGameDetails(GameDetails gameDetails);
        Task<IEnumerable<GameDetails>> GetAll();
    }
}
