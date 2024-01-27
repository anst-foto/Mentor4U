using System.Windows;

namespace Mentor4U.WpfClassic.Windows.StartWindow;

public partial class StartWindow : Window
{
    public StartWindow()
    {
        InitializeComponent();
    }

    private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}