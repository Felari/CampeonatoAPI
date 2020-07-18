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

            CreateMap<TimeEntity, TimeEntity>()
                .PreserveReferences();
            CreateMap<TimeEntity, VisualizaTimeViewModel>()
                .ForMember(x => x.Id, y => y.MapFrom(src => src.Id))
                .ForMember(x => x.Nome, y => y.MapFrom(src => src.Nome))
                .ForMember(x => x.Participantes, y => y.MapFrom(src => src.Participantes))
                .ForMember(x => x.PartidasCasa, y => y.MapFrom(src => src.PartidasCasa))
                .ForMember(x => x.PartidasVisitante, y => y.MapFrom(src => src.PartidasVisitante))
                .PreserveReferences();

            CreateMap<VisualizaTimeViewModel, TimeEntity>()
                .ForMember(x => x.Id, y => y.MapFrom(src => src.Id))
                .ForMember(x => x.Nome, y => y.MapFrom(src => src.Nome))
                .ForMember(x => x.Participantes, y => y.MapFrom(src => src.Participantes))
                .ForMember(x => x.PartidasCasa, y => y.MapFrom(src => src.PartidasCasa))
                .ForMember(x => x.PartidasVisitante, y => y.MapFrom(src => src.PartidasVisitante))
                .PreserveReferences();
        }

    }
}
