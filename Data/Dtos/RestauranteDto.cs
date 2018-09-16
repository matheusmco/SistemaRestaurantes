using System.Collections.Generic;
using SistemaRestaurantes.Data.Models;

namespace SistemaRestaurantes.Data.Dtos
{
    public class RestauranteDto
    {
        public int RestauranteId { get; set; }
        public string Nome { get; set; }

        public RestauranteDto(RestauranteModel Restaurante)
        {
            this.RestauranteId = Restaurante.RestauranteId;
            this.Nome = Restaurante.Nome;
        }

        public RestauranteDto() { }
    }
}