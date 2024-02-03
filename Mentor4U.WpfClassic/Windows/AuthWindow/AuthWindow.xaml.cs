using System.Windows;
using System.Windows.Input;

namespace Mentor4U.WpfClassic.Windows.AuthWindow;

public partial class AuthWindow : Window
{
    public AuthWindow()
    {
        InitializeComponent();
    }

    private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        this.DragMove();
    }
}