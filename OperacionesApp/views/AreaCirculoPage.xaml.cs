using System;

namespace OperacionesApp.Views
{
    public partial class AreaCirculoPage : ContentPage
    {
        public AreaCirculoPage()
        {
            InitializeComponent();
        }

        private void CalcularArea_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RadioEntry.Text))
            {
                DisplayAlert("Error", "Por favor, introduce un valor para el radio.", "OK");
                return;
            }

            if (double.TryParse(RadioEntry.Text, out double radio) && radio > 0)
            {
                double area = Math.PI * Math.Pow(radio, 2);
                ResultadoLabel.Text = $"Resultado: {area:F2}";
                ResultadoLabel.IsVisible = true;
            }
            else
            {
                DisplayAlert("Error", "Introduce un valor numérico positivo.", "OK");
            }
        }

        private void Limpiar_Clicked(object sender, EventArgs e)
        {
            RadioEntry.Text = string.Empty;
            ResultadoLabel.IsVisible = false;
        }
    }
}
