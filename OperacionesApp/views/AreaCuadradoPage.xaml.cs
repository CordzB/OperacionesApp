using System;

namespace OperacionesApp.Views
{
    public partial class AreaCuadradoPage : ContentPage
    {
        public AreaCuadradoPage()
        {
            InitializeComponent();
        }

        private void CalcularArea_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LadoEntry.Text))
            {
                DisplayAlert("Error", "Por favor, introduce un valor para el lado.", "OK");
                return;
            }

            if (double.TryParse(LadoEntry.Text, out double lado) && lado > 0)
            {
                double area = lado * lado;
                ResultadoLabel.Text = $"Resultado: {area}";
                ResultadoLabel.IsVisible = true;
            }
            else
            {
                DisplayAlert("Error", "Introduce un valor numérico positivo.", "OK");
            }
        }

        private void Limpiar_Clicked(object sender, EventArgs e)
        {
            LadoEntry.Text = string.Empty;
            ResultadoLabel.IsVisible = false;
        }
    }
}
