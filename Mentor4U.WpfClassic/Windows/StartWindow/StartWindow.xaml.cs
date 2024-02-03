using System.ComponentModel;
using System.Windows;

namespace Mentor4U.WpfClassic.Windows.StartWindow;

public partial class StartWindow : Window
{
    public StartWindow()
    {
        InitializeComponent();
        
        this.Closing += OnClosing;
    }

    private void OnClosing(object? sender, CancelEventArgs e)
    {
        var result = MessageBox.Show(
            owner: this,
            messageBoxText: "Вы действительно хотите закрыть приложение?",
            caption: App.Current.Resources["AppTitle"].ToString(),
            button: MessageBoxButton.YesNo,
            icon: MessageBoxImage.Stop);
        if (result == MessageBoxResult.No)
        {
            e.Cancel = true;
        }
    }

    private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void ButtonAuth_OnClick(object sender, RoutedEventArgs e)
    {
        new AuthWindow.AuthWindow().Show();
        this.Closing -= OnClosing;
        this.Close();
    }
}