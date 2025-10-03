using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MusicNotesWeb.Entity.models;

namespace MusicNotesWeb.Application.Profile
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateGameDetailsContract, GameDetails>()
                .ReverseMap();
            CreateMap<CreateNoteAttemptContract, NoteAttempt>()
                .ReverseMap();
        }

        public AutoMapperProfile(string profileName) : base(profileName)
        {
        }

        protected override void Configure()
        {
        }
    }
}
