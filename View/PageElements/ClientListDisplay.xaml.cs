using Model;
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

namespace Dimithrius004.View.PageElements
{
    /// <summary>
    /// Interaction logic for ClientListDisplay.xaml
    /// </summary>
    public partial class ClientListDisplay : UserControl
    {
        private readonly Frame _container;
        public Client _client { get; set; }

        public ClientListDisplay(Client client, Frame container)
        {
            _container = container;
            _client = client;
            InitializeComponent();

            clientName.Content = _client.Name;
            clientSistemCode.Content = _client.SistCod;
            clientCNPJ.Content = _client.CNPJ;
            clientTaxation.Content = _client.Taxation;
        }

        private void BtDetails_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
