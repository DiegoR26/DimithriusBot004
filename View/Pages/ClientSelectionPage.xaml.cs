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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dimithrius004.View.Pages
{
    /// <summary>
    /// Interaction logic for ClientSelectionPage.xaml
    /// </summary>
    public partial class ClientSelectionPage : Page
    {
        private Frame _container;

        public ClientSelectionPage(Frame container)
        {
            InitializeComponent();
            _container = container;
        }

        private void BtAddClient_Click(object sender, RoutedEventArgs e)
        {
            _container.Navigate(new ClientDetailPage(_container, false));
        }
    }
}
