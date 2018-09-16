using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SistemaRestaurantes.Data.Dtos;
using SistemaRestaurantes.Data.Models;

namespace SistemaRestaurantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        private Context _context;

        public RestauranteController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RestauranteDto>> Get()
        {
            var Restaurantes = _context.Restaurantes.Select(x => new RestauranteDto(x)).ToList();

            if (Restaurantes.Count == 0)
            {
                return NotFound();
            }
            return Restaurantes;
        }

        [HttpGet("{id}")]
        public ActionResult<RestauranteDto> Get(int id)
        {
            var Restaurante = _context.Restaurantes.Select(x => new RestauranteDto(x)).Where(x => x.RestauranteId == id).FirstOrDefault();

            if (Restaurante == null)
            {
                return NotFound();
            }
            return Restaurante;
        }

        [HttpPost]
        public ActionResult<RestauranteDto> Post([FromBody] RestauranteDto RestauranteDto)
        {
            var Restaurante = new RestauranteModel(RestauranteDto);

            if (Restaurante.RestauranteId > 0)
            {
                _context.Restaurantes.Update(Restaurante);
            }
            else
            {
                _context.Restaurantes.Add(Restaurante);
            }

            _context.SaveChanges();

            var RestauranteRetorno = _context.Restaurantes.Select(x => new RestauranteDto(x)).Where(x => x.RestauranteId == Restaurante.RestauranteId).First();

            if (RestauranteRetorno == null)
            {
                return NotFound();
            }
            return RestauranteRetorno;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Restaurantes.Remove(_context.Restaurantes.Where(x => x.RestauranteId == id).FirstOrDefault());
            _context.SaveChanges();
        }
    }
}
