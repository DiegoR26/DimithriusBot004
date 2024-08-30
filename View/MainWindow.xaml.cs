using Dimithrius004.View.Pages;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dimithrius004
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void BtClients_Click(object sender, RoutedEventArgs e)
        {
            Container.Navigate(new ClientSelectionPage(Container));
        }

        private void BtExit_Click(object sender, RoutedEventArgs e)
        {
            //Fazer janela de dialogo para fechar
            Close();
        }

    }
}