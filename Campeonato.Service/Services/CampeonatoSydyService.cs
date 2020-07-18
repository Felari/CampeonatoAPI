using AutoMapper;
using Campeonato.Domain.Entidade;
using Campeonato.Domain.Interfaces;
using Campeonato.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Campeonato.Service.Services
{
    public class CampeonatoSydyService : IServiceCampeonatoSydy
    {

        private readonly IRepositoryCampeonatoSydy _repository;
        private readonly IRepositoryTime _repositoryTime;
        public CampeonatoSydyService(IRepositoryCampeonatoSydy repositoryCampeonato, IRepositoryTime repositoryTime)
        {
            _repository = repositoryCampeonato;
            _repositoryTime = repositoryTime;
        }

        public VisualizaCampeonatoSydyViewModel RecoverAll()
        {
            var campeonato = _repository.GetAll()
                .FirstOrDefault();

            var listaResultado = _repositoryTime.GetAll()
                .Where(time => time.Participantes.Any(par => par.CampeonatoId == campeonato.Id))
                .ToList()
                .Select(time => {
                    //PartidasCasa PartidasVisitante
                    //Calcular resultado
                    var resCasa = 0;
                    resCasa = time.PartidasCasa.Select(partidaCasa => {
                        var ponto = 0;
                        if (partidaCasa.GolTimeCasa > partidaCasa.GolTimeVisitante)
                            ponto = 3;
                        else if (partidaCasa.GolTimeCasa == partidaCasa.GolTimeVisitante)
                            ponto = 1;
                        return ponto;
                    }).ToList().Sum(x => x);
                    var resVisitante = 0;
                    resVisitante = time.PartidasVisitante.Select(partidaVisitante => {
                        var ponto = 0;
                        if (partidaVisitante.GolTimeCasa < partidaVisitante.GolTimeVisitante)
                            ponto = 3;
                        else if (partidaVisitante.GolTimeCasa == partidaVisitante.GolTimeVisitante)
                            ponto = 1;
                        return ponto;
                    }).ToList().Sum(x => x);

                    //Retornar new { timeId, resultado}
                    return new { Time = time.Nome, Resultado = resCasa + resVisitante };
                }).OrderByDescending(x => x.Resultado).ToList();

            List<VisualizaPartidaViewModel> listaDePartidas = new List<VisualizaPartidaViewModel>();
            foreach (var a in campeonato.Partidas)
            {
                VisualizaPartidaViewModel novaPart = new VisualizaPartidaViewModel
                {
                    GolsTimeCasa = a.GolTimeCasa,
                    GolsTimeVisitante = a.GolTimeVisitante,
                    TimeCasa = a.TimeCasa.Nome,
                    TimeVisitante = a.TimeVisitante.Nome
                };
                listaDePartidas.Add(novaPart);
            }

            VisualizaCampeonatoSydyViewModel resultado = new VisualizaCampeonatoSydyViewModel
            {
                Campeao = listaResultado[0].Time,
                Vice = listaResultado[1].Time,
                Terceiro = listaResultado[2].Time,
                Partidas = listaDePartidas
            };

            return resultado;
        }

    }
}
