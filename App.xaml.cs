namespace MauiAppHotel
{
    public partial class App : Application
    {
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
