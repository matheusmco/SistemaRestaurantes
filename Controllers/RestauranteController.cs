using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return new List<RestauranteDto>();
        }

        [HttpGet("{id}")]
        public ActionResult<RestauranteDto> Get(int id)
        {
            return new RestauranteDto();
        }

        [HttpPost]
        public ActionResult<RestauranteDto> Post([FromBody] RestauranteDto Restaurante)
        {
            return new RestauranteDto();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
