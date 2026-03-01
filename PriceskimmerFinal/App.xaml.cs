using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Devices.Sensors;


namespace PriceskimmerFinal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
           // GetLocation();
        }
        private async void GetLocation()
        {
            var location = await Geolocation.Default.GetLastKnownLocationAsync();
            if(location == null)
            {
                location = await Geolocation.Default.GetLocationAsync(
                    new GeolocationRequest(GeolocationAccuracy.Medium));
            }
            if(location != null)
            {
                double lat = location.Latitude;
                double lng = location.Longitude;
            }
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}