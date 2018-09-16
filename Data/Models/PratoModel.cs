using System.Collections.Generic;

namespace SistemaRestaurantes.Data.Models
{
    public class PratoModel
    {
        public int PratoId { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public RestauranteModel Restaurante { get; set; }
    }
}