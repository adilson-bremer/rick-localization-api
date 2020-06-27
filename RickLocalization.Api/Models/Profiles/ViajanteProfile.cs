using AutoMapper;
using RickLocalization.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Api.Models.Profiles {

    public class ViajanteProfile : Profile {

        public ViajanteProfile() {

            _ = CreateMap<Viajante, ViajanteDto>()
                .ForMember(
                    dest => dest.Dimensao,
                    src => src.MapFrom(src => src.Dimensao.Nome)
                ).ForMember(
                    dest => dest.Descricao, 
                    src => src.MapFrom(src => src.Dimensao.Descricao)
                );
        }
    }
}
