using Model;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ViewModel
{
    public class ClientDetailViewModel : BaseViewModel
    {
        private Client _client;

        private bool _isEditing;

        public ClientDetailViewModel()
        {
            EditCommand = new RelayCommand(EditClient);
            SaveCommand = new RelayCommand(SaveClient);
            DeleteCommand = new RelayCommand(DeleteClient);
            CancelCommand = new RelayCommand(CancelEdit);

            Client = new Client();
            IsEditing = false;
        }

        public ClientDetailViewModel(Client client, bool isEditing)
        {
            Client = client;
            IsEditing = isEditing;
            EditCommand = new RelayCommand(EditClient);
            SaveCommand = new RelayCommand(SaveClient);
            DeleteCommand = new RelayCommand(DeleteClient);
            CancelCommand = new RelayCommand(CancelEdit);
        }

        public Client Client
        {
            get => _client;
            set
            {
                _client = value;
                OnPropertyChanged();
            }
        }

        public bool IsEditing
        {
            get => _isEditing;
            set
            {
                _isEditing = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsViewing));
            }
        }

        public bool IsViewing => !IsEditing;

        public ICommand EditCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand CancelCommand { get; }

        private void EditClient()
        {
            IsEditing = true;
        }

        private void SaveClient()
        {
            IsEditing = false;
        }

        private void DeleteClient()
        {

        }

        private void CancelEdit()
        {
            IsEditing = false;
        }
    }
}
