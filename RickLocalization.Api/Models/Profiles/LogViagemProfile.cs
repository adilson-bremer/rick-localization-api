using AutoMapper;
using RickLocalization.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Api.Models.Profiles {

    public class LogViagemProfile : Profile {

        public LogViagemProfile() {

            CreateMap<LogViagem, LogViagemCreateDto>().ReverseMap();
        }
    }
}
