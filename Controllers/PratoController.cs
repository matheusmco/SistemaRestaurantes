using System.Collections.Generic;
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
            return new PratoDto();
        }

        [HttpGet]
        public ActionResult<IEnumerable<PratoDto>> Get()
        {
            return new List<PratoDto>();
        }

        [HttpGet("{id}")]
        public ActionResult<PratoDto> Get(int id)
        {
            return new PratoDto();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}