using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MusicNotesWeb.Entity.models
{
    public class NoteAttempt
    {
        public int Id { get; set; }
        public int GameDetailsId { get; set; }
        public GameDetails GameDetails { get; set; }
        public string ExpectedNote { get; set; }
        public string PlayedNote { get; set; }
        public int OctaveNr { get; set; }

        public bool IsCorrect
        {
            get { return ExpectedNote == PlayedNote; }
        }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime UpdatedOn { get; set; }
    }

    public class CreateNoteAttemptContract
    {
        //public CreateGameDetailsContract GameDetails { get; set; }
        public string ExpectedNote { get; set; }
        public string PlayedNote { get; set; }
        public int OctaveNr { get; set; }
    }

}
