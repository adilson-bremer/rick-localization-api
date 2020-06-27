using AutoMapper;
using RickLocalization.Domain.Entities;

namespace RickLocalization.Api.Models.Profiles {

    public class DimensaoProfile : Profile {

        public DimensaoProfile() {

            CreateMap<Dimensao, DimensaoDto>();
        }
    }
}
