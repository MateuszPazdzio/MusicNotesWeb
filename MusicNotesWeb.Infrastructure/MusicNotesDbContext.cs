using Microsoft.EntityFrameworkCore;
using MusicNotesWeb.Entity.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicNotesWeb.Infrastructure
{
    public class MusicNotesDbContext : DbContext
    {
        public virtual DbSet<GameDetails> GameDetails { get; set; }
        public virtual DbSet<NoteAttempt> NoteAttempts{ get; set; }

        public MusicNotesDbContext(DbContextOptions<MusicNotesDbContext> options) : base(options)
        {

        }

        //protected MusicNotesDbContext()
        //{
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GameDetails>()
                .HasMany(r => r.Attempts)
                .WithOne(a => a.GameDetails)
                .HasForeignKey(a => a.GameDetailsId);

        }
    }
}
