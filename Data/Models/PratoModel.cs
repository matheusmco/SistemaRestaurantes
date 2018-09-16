using System.Collections.Generic;
using SistemaRestaurantes.Data.Dtos;

namespace SistemaRestaurantes.Data.Models
{
    public class PratoModel
    {
        public int PratoId { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int RestauranteId { get; set; }
        public RestauranteModel Restaurante { get; set; }

        public PratoModel() { }

        public PratoModel(PratoDto Prato)
        {
            this.PratoId = Prato.PratoId;
            this.Nome = Prato.Nome;
            this.Preco = Prato.Preco;
            this.RestauranteId = Prato.Restaurante.RestauranteId;
        }
    }
}