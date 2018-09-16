using System.Collections.Generic;
using SistemaRestaurantes.Data.Dtos;

namespace SistemaRestaurantes.Data.Models
{
    public class RestauranteModel
    {
        public int RestauranteId { get; set; }
        public string Nome { get; set; }
        public List<PratoModel> Pratos { get; set; }

        public RestauranteModel() { }

        public RestauranteModel(RestauranteDto Restaurante)
        {
            this.RestauranteId = Restaurante.RestauranteId;
            this.Nome = Restaurante.Nome;
        }
    }
}