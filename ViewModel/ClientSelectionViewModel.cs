using Data;
using Dimithrius004.View.PageElements;
using Model;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Controls;

namespace ViewModel
{
    public class ClientSelectionViewModel : BaseViewModel
    {
        private readonly Frame _container;
        private readonly ClientRepository _clientRepository;

        public List<ClientListDisplay> ClientListDisplays { get; set; }

        public ClientSelectionViewModel(Frame container)
        {
            _container = container;
            _clientRepository = new ClientRepository(new AppDBContext());
            CreateClientDisplays();
        }

        public async void CreateClientDisplays()
        {
            List<Client> clients = await _clientRepository.GetAllClientsAsync();
        }
        
    }
}
