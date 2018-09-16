using SistemaRestaurantes.Data.Models;

namespace SistemaRestaurantes.Data.Dtos
{
    public class PratoDto
    {
        public int PratoId { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public RestauranteDto Restaurante { get; set; }

        public PratoDto() { }

        public PratoDto(PratoModel Prato, RestauranteModel Restaurante)
        {
            this.PratoId = Prato.PratoId;
            this.Nome = Prato.Nome;
            this.Preco = Prato.Preco;
            this.Restaurante = new RestauranteDto(Restaurante);
        }
    }
}