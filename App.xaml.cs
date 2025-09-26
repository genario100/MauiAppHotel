using MauiAppHotel.Models;
namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Models.Quarto> lista_quartos = new List<Models.Quarto>
        {
            new Models.Quarto
            {
                Nome = "Standard",
                Descricao = "Quarto confortável com amenidades básicas.",
                ValorDiariaAdulto = 150.00,
                ValorDiariaCrianca = 75.00
            },
            new Models.Quarto
            {
                Nome = "Deluxe",
                Descricao = "Quarto espaçoso com vista para o mar e amenidades premium.",
                ValorDiariaAdulto = 250.00,
                ValorDiariaCrianca = 125.00
            },
            new Models.Quarto
            {
                Nome = "Suíte",
                Descricao = "Suíte luxuosa com sala de estar separada e banheira de hidromassagem.",
                ValorDiariaAdulto = 400.00,
                ValorDiariaCrianca = 200.00
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Title = "Hotel Management App";
            window.Width = 450;
            window.Height = 900;

            return window;
        }
    }
}
