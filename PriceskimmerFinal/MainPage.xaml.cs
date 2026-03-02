using PriceskimmerFinal.ViewModels;

namespace PriceskimmerFinal
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void OnSliderValueChanged(object? sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            DistanceInMiles.Text = $"{value:F0} mi";
        }

        
    }
}
