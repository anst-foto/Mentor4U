using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mentor4U.WpfClassic.Windows.StartWindow.PersonalStartWindows.SorokinVariantStartWindow
{
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
            this.Closing += (_, e) =>
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
            };
        }

        private void BtnCloseApp_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
