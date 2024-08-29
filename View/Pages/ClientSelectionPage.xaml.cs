using System.Windows;
using System.Windows.Controls;

using ViewModel;
using Model;

namespace Dimithrius004.View.Pages
{
    /// <summary>
    /// Interaction logic for ClientSelectionPage.xaml
    /// </summary>
    public partial class ClientSelectionPage : Page
    {
        private readonly Frame _container;

        public ClientSelectionPage(Frame container)
        {
            InitializeComponent();
            _container = container;
        }

        private void BtAddClient_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = new ClientDetailViewModel(new Client(), true);
            var clientDetailView = new ClientDetailPage(_container) { DataContext = viewModel };

            _container.Navigate(clientDetailView);
        }
    }
}
