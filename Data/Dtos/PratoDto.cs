namespace SistemaRestaurantes.Data.Dtos
{
    public class PratoDto
    {
        public int PratoId { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public RestauranteDto Restaurante { get; set; }
    }
}