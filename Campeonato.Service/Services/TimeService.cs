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
    public class TimeService : IServiceTime
    {

        private readonly IRepositoryTime _repository;

        public TimeService(IRepositoryTime repositoryTime)
        {
            _repository = repositoryTime;
        }
        public IEnumerable<VisualizaTimeViewModel> RecoverAll()
        {
            var times = _repository.GetAll().ToList();
            VisualizaTimeViewModel teste = new VisualizaTimeViewModel { Nome = times.FirstOrDefault().Nome };
            var timesVM = Mapper.Map<List<TimeEntity>, List<VisualizaTimeViewModel>>(times);
            return timesVM;
        }

        public VisualizaTimeViewModel RecoverById(int id)
        {
            var time = _repository.GetById(id);
            VisualizaTimeViewModel timeVM = Mapper.Map<TimeEntity, VisualizaTimeViewModel>(time);
            return timeVM;
        }


        public void Delete(int id) =>
            _repository.Remove(id);

        public VisualizaTimeViewModel Insert(AdicionaTimeViewModel timeViewModel)
        {
            var time = Mapper.Map<AdicionaTimeViewModel, TimeEntity>(timeViewModel);
            _repository.Save(time);
            return Mapper.Map<TimeEntity, VisualizaTimeViewModel>(time);
        }


        public VisualizaTimeViewModel Update(int id, AtualizaTimeViewModel timeViewModel)
        {
            if (id != timeViewModel.Id)
            {
                    return default;
            }
            var time = Mapper.Map<AtualizaTimeViewModel, TimeEntity>(timeViewModel);

            _repository.Save(time);
            return Mapper.Map<TimeEntity, VisualizaTimeViewModel>(time);
        }

    }
}
