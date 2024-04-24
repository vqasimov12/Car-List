using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using WpfApp5.Models;

namespace WpfApp5.Views;
public partial class Window1 : Window, INotifyPropertyChanged
{


    public ObservableCollection<Car> Cars { get; set; }
    public event PropertyChangedEventHandler? PropertyChanged;

    private Car myCar;

    public Car MyCar
    {
        get { return myCar; }
        set
        {
            myCar = value;
            OnPropertyChanged();
        }

    }

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public Window1()
    {
        Cars = new();
        InitializeComponent();
        DataContext = this;
    }

    private void ADD_Click(object sender, RoutedEventArgs e)
    {
        MyCar = new();
        CarView cv = new();
        cv.MyCar = MyCar;
        cv.ButtonName = "Add";
        if (cv.ShowDialog() == true)
            Cars.Add(MyCar!);

    }

    private void CarList_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {

        MyCar = (sender as ListView)?.SelectedItem as Car;
        if (MyCar is not null)
        {
            CarView cv = new();
            Car temp = new() { Model = MyCar.Model, Year = MyCar.Year, Vendor = MyCar.Vendor };
            cv.MyCar = temp;
            cv.ButtonName = "Update";
            if (cv.ShowDialog() == true)
            {
                MyCar.Vendor = temp.Vendor;
                MyCar.Year = temp.Year;
                MyCar.Model = temp.Model;
            }
        }

    }
}
