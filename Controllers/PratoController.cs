using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SistemaRestaurantes.Data.Dtos;
using SistemaRestaurantes.Data.Models;

namespace SistemaRestaurantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratoController : ControllerBase
    {
        private Context _context;
        public PratoController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult<PratoDto> Post(PratoDto PratoDto)
        {
            var Prato = new PratoModel(PratoDto);

            if (Prato.PratoId > 0)
            {
                _context.Pratos.Update(Prato);
            }
            else
            {
                _context.Pratos.Add(Prato);
            }

            _context.SaveChanges();

            var PratoRetorno = _context.Pratos.Select(x => new PratoDto(x, _context.Restaurantes.Where(r => r.RestauranteId == x.RestauranteId).FirstOrDefault())).Where(x => x.PratoId == Prato.PratoId).First();

            if (PratoRetorno == null)
            {
                return NotFound();
            }

            return PratoRetorno;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PratoDto>> Get()
        {
            var Pratos = _context.Pratos.Select(x => new PratoDto(x, _context.Restaurantes.Where(r => r.RestauranteId == x.RestauranteId).FirstOrDefault())).ToList();

            if (Pratos.Count == 0)
            {
                return NotFound();
            }
            return Pratos;
        }

        [HttpGet("{id}")]
        public ActionResult<PratoDto> Get(int id)
        {
            var PratoRetorno = _context.Pratos.Select(x => new PratoDto(x, _context.Restaurantes.Where(r => r.RestauranteId == x.RestauranteId).FirstOrDefault())).Where(x => x.PratoId == id).FirstOrDefault();

            if (PratoRetorno == null)
            {
                return NotFound();
            }

            return PratoRetorno;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Pratos.Remove(_context.Pratos.Where(x => x.PratoId == id).FirstOrDefault());
            _context.SaveChanges();
        }
    }
}