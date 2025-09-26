namespace MauiAppHotel.Models
{
    public class Quarto
    {
        public string Descricao { get; set; }
        public double ValorDiariaAdulto { get; set; }
        public double ValorDiariaCrianca { get; set; }
        public string Nome { get; internal set; }
    }
}