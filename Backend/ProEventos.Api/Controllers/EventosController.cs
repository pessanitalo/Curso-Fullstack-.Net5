using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Application.Contratos;
using ProEventos.Application.Dtos;
using System;
using System.Threading.Tasks;

namespace ProEventos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private readonly IEventoService _eventoService;

        public EventosController(IEventoService eventoService)
        {
            _eventoService = eventoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var eventos = await _eventoService.GetAllEventosAsync();
                if (eventos == null) return NotFound("Nenhum evento encontrado");

                return Ok(eventos);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro não foi possivel carregar os eventos: {ex.Message}");
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetIdAssync(int id)
        {
            try
            {
                var evento = await _eventoService.GetEventosByIdAsync(id);
                if (evento == null) return BadRequest("Nenhum evento encontrado");

                return Ok(evento);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro não foi possivel carregar os eventos: {ex.Message}");
            }

        }

        [HttpGet("tema/{tema}")]
        public async Task<IActionResult> GetTemaAssync(string tema)
        {
            try
            {
                var evento = await _eventoService.GetAllEventosByTemaAsync(tema);
                if (evento == null) return BadRequest("Nenhum tema encontrado");

                return Ok(evento);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro não foi possivel carregar os eventos: {ex.Message}");
            }

        }

        [HttpPost]
        public async Task<IActionResult> Post(EventoDto model)
        {
            try
            {
                var evento = await _eventoService.AddEventos(model);
                if (evento == null) return BadRequest("Evento não cadastrado");

                return Ok(evento);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro não foi possivel carregar os eventos: {ex.Message}");
            }

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, EventoDto model)
        {
            try
            {
                var evento = await _eventoService.UpdateEventos(id, model);
                if (evento == null) return BadRequest("Evento não atualizado");

                return Ok(evento);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro não foi possivel carregar os eventos: {ex.Message}");
            }

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteAsync(int id)
        {
            try
            {
                if (await _eventoService.deleteEventos(id))
                    return Ok("Deletado");
                else
                    return BadRequest("Evento não deletado");

            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro não foi possivel carregar os eventos: {ex.Message}");
            }

        }
    }
}
