using AutoMapper;
using Campeonato.Domain.Entidade;
using Campeonato.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Infra.Data.Mapper
{
    public class TimeMapper : Profile
    {
        public TimeMapper()
        {
            CreateMap<AdicionaTimeViewModel, TimeEntity>()
                .ForMember(x => x.Nome, y => y.MapFrom(src => src.Nome))
                .PreserveReferences()
                .ReverseMap();


            CreateMap<AtualizaTimeViewModel, TimeEntity>()
                .PreserveReferences();

            CreateMap<VisualizaTimeViewModel, AtualizaTimeViewModel>()
                .PreserveReferences();

            CreateMap<TimeEntity, TimeEntity>()
                .PreserveReferences();
            CreateMap<TimeEntity, VisualizaTimeViewModel>()
                .ForMember(x => x.Id, y => y.MapFrom(src => src.Id))
                .ForMember(x => x.Nome, y => y.MapFrom(src => src.Nome))

                .PreserveReferences();

            CreateMap<VisualizaTimeViewModel, TimeEntity>()
                .ForMember(x => x.Id, y => y.MapFrom(src => src.Id))
                .ForMember(x => x.Nome, y => y.MapFrom(src => src.Nome))

                .PreserveReferences();
        }

    }
}
