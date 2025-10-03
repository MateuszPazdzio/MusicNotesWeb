using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicNotesWeb.Entity.models
{
    public class GameDetails
    {
        public int Id { get; set; }
       
        public List<NoteAttempt> Attempts { get; set; } = new List<NoteAttempt>();

        public int CorrectNotesCount
        {
            get { return Attempts.Count(a => a.IsCorrect); }
        }

        public int TotalNotesCount
        {
            get { return Attempts.Count; }
        }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime UpdatedOn { get; set; }

    }

    public class CreateGameDetailsContract
    {
        public List<CreateNoteAttemptContract> Attempts { get; set; } = new List<CreateNoteAttemptContract>();
        public DateTime CreatedOn { get; set; }
    }

}
