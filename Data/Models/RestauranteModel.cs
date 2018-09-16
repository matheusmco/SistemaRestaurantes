using System.Collections.Generic;

namespace SistemaRestaurantes.Data.Models
{
    public class RestauranteModel
    {
        public int RestauranteId { get; set; }
        public string Nome { get; set; }
        public List<PratoModel> Pratos { get; set; }
    }
}