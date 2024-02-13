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

namespace WPF
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void BtnConfirmSettings_Click(object sender, RoutedEventArgs e)
        {
            if (RbWindowed.IsChecked == true || RbFullscreen.IsChecked == true)
            {
                if (MessageBox.Show("Are you sure?", "Warning!", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
                {
                    ChangeDisplayMode();
                }
                else
                {
                    var mainWindow = new MainWindow();
                    Close();
                    mainWindow.Show();
                }
            } 
            else
            {
                MessageBox.Show("Select display mode!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            
        }

        private void ChangeDisplayMode()
        {
            var mainWindow = new MainWindow();

            if (RbWindowed.IsChecked == true)
            {
                mainWindow.WindowState = WindowState.Normal;
                Close();
                mainWindow.Show();
            }
            else if (RbFullscreen.IsChecked == true)
            {
                mainWindow.WindowState = WindowState.Maximized;
                Close();
                mainWindow.Show();
            }
        }
    }
}
