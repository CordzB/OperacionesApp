using System;

namespace OperacionesApp.Views
{
    public partial class AreaRectanguloPage : ContentPage
    {
        public AreaRectanguloPage()
        {
            InitializeComponent();
        }

        private void CalcularArea_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BaseEntry.Text) || string.IsNullOrWhiteSpace(AlturaEntry.Text))
            {
                DisplayAlert("Error", "Por favor, completa todos los campos.", "OK");
                return;
            }

            if (double.TryParse(BaseEntry.Text, out double baseRect) && baseRect > 0 &&
                double.TryParse(AlturaEntry.Text, out double alturaRect) && alturaRect > 0)
            {
                double area = baseRect * alturaRect;
                ResultadoLabel.Text = $"Resultado: {area}";
                ResultadoLabel.IsVisible = true;
            }
            else
            {
                DisplayAlert("Error", "Introduce valores numéricos positivos.", "OK");
            }
        }

        private void Limpiar_Clicked(object sender, EventArgs e)
        {
            BaseEntry.Text = string.Empty;
            AlturaEntry.Text = string.Empty;
            ResultadoLabel.IsVisible = false;
        }
    }
}
