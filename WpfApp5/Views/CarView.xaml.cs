using System.Windows;
using WpfApp5.Models;

namespace WpfApp5.Views;
public partial class CarView : Window
{
    public Car MyCar { get; set; }
    public string ButtonName { get; set; } = "";
    public CarView()
    {
        InitializeComponent();
        DataContext = this;
    }

    private void Add_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
    }

    private void Cancel_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
    }
}
