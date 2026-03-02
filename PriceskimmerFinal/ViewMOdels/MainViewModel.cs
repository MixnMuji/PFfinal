using System.ComponentModel;
using System.Runtime.CompilerServices;
using PriceskimmerFinal.Services;
using Xamarin.Google.Crypto.Tink.Shaded.Protobuf;

namespace PriceskimmerFinal.ViewModels;
public class MainViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private string _serachQ;
    private double _distnace;

    public string searchQ
    {
        get => _serachQ;  // look into later to figure out how this would work when you have a db
        set {
            _serachQ = value;
            OnPropertyChanged();
        }
    }
    public double distance
    {
        get => _distnace;
        set { _distnace = value;
            OnPropertyChanged();
                }
    }
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}