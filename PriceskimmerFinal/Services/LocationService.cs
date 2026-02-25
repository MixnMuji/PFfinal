using Microsoft.Maui.Devices.Sensors;

namespace PriceskimmerFinal.Services;

public class LocationService
{
    public async Task<Location?> GetLocationAsync()
    {
        try
        {
            var location = await Geolocation.Default.GetLocationAsync(
                new GeolocationRequest(GeolocationAccuracy.Medium));

            return location;
        }
        catch
        {
            return null;
        }
    }
}