using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp5.Models;

public class Car : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
    string model { get; set; }
    public string Model
    {
        get =>  model;
        set
        {
            model = value;
            OnPropertyChanged();
        }
    }
    string vendor { get; set; }
    public string Vendor
    {
        get => vendor;
        set
        {
            vendor = value;
            OnPropertyChanged();
        }
    }  
    int year { get; set; }
    public int Year
    {
        get => year;
        set
        {
            year = value;
            OnPropertyChanged();
        }
    }
}
