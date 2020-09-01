using System.Windows;
using System.Windows.Controls;

namespace ControlsTemplates.Examples
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 50; i++)
            {
                MenuItem newMI = new MenuItem
                {
                    Header = "Item " + i.ToString()
                };
                topFour.Items.Add(newMI);
            }

            return;
        }

        private void OpenWindow(object sender, RoutedEventArgs args)
        {
            new TestWindow().Visibility = Visibility.Visible;
        }

        private void OpenNavWindow(object sender, RoutedEventArgs args)
        {
            new TestNavigationWindow().Visibility = Visibility.Visible;
        }
    }
}