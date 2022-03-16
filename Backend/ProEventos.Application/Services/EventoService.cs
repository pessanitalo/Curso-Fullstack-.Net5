using AutoMapper;
using ProEventos.Application.Contratos;
using ProEventos.Application.Dtos;
using ProEventos.Domain.Models;
using ProEventos.Persistence.Interfaces;
using System;
using System.Threading.Tasks;

namespace ProEventos.Application.Services
{
    public class EventoService : IEventoService
    {
        private readonly IGenericRepository _genericRepository;
        private readonly IEventoRepository _eventoRepository;
        private readonly IMapper _mapper;
        public EventoService(IGenericRepository genericRepository, IEventoRepository eventoRepository, IMapper mapper)
        {
            _mapper = mapper;
            _genericRepository = genericRepository;
            _eventoRepository = eventoRepository;

        }

        public async Task<EventoDto> AddEventos(EventoDto model)
        {
            try
            {
                var evento = _mapper.Map<Evento>(model);

                _genericRepository.Add(evento);
                if (await _genericRepository.SaveChangesAsync())
                {
                    var retorno = await _eventoRepository.GetEventosByIdAsync(evento.Id);
                    return _mapper.Map<EventoDto>(retorno);
                }
                return null;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        public async Task<EventoDto> UpdateEventos(int eventoId, EventoDto model)
        {
            try
            {
                var evento = await _eventoRepository.GetEventosByIdAsync(eventoId);
                if (evento == null) return null;

                model.Id = evento.Id;

                _mapper.Map(model, evento);

                _genericRepository.Update<Evento>(evento);

                if (await _genericRepository.SaveChangesAsync())
                {
                    var eventoRetorno = await _eventoRepository.GetEventosByIdAsync(evento.Id);

                    return _mapper.Map<EventoDto>(eventoRetorno);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        

        public async Task<bool> deleteEventos(int eventoId)
        {
            try
            {
                var evento = await _eventoRepository.GetEventosByIdAsync(eventoId);
                if (evento == null) throw new Exception("Evento não encontrado");

                _genericRepository.Delete<Evento>(evento);

                return await _genericRepository.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<EventoDto[]> GetAllEventosAsync()
        {
            try
            {
                var eventos = await _eventoRepository.GetAllEventosAsync();
                if (eventos == null) return null;

                var result = _mapper.Map<EventoDto[]>(eventos);

                return result;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<EventoDto[]> GetAllEventosByTemaAsync(string tema)
        {
            try
            {
                var eventos = await _eventoRepository.GetAllEventosByTemaAsync(tema);
                if (eventos == null) return null;

                var result = _mapper.Map<EventoDto[]>(eventos);

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<EventoDto> GetEventosByIdAsync(int eventoId)
        {
            try
            {
                var evento = await _eventoRepository.GetEventosByIdAsync(eventoId);
                if (evento == null) return null;

                var result = _mapper.Map<EventoDto>(evento);
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }
}
