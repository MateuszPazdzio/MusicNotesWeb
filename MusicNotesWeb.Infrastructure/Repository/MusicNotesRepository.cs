using Microsoft.EntityFrameworkCore;
using MusicNotesWeb.Entity.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicNotesWeb.Infrastructure.Repository
{
    public class MusicNotesRepository : IMusicNotesRepository
    {
        private readonly MusicNotesDbContext _ctx;

        public MusicNotesRepository(MusicNotesDbContext ctx)
        {
            this._ctx = ctx;
        }

        public async Task<bool> CreateGameDetails(GameDetails gameDetails)
        {
            await _ctx.AddAsync(gameDetails);
            return await _ctx.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<GameDetails>> GetAll()
        {
            try
            {
                return await _ctx.GameDetails
                        .Include(r => r.Attempts)
                        .ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
