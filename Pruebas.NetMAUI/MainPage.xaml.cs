namespace Pruebas.NetMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count+=5;

            if (count == 1)
                CounterBtn.Text = $"Clicado {count} veces";
            else
                CounterBtn.Text = $"Clicado {count} veces";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
