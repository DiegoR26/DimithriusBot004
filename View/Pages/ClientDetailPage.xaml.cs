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
    /// Interaction logic for ClientDetailPage.xaml
    /// </summary>
    public partial class ClientDetailPage : Page
    {
        private Frame _container;
        private bool LockedState;

        public ClientDetailPage(Frame container, bool state)
        {
            InitializeComponent();
            _container = container;
            LockedState = state;

            ButtonsStateChange();
        }

        public void ButtonsStateChange()
        {
            if (LockedState)
            {
                BtEditSave.Content = "Editar";
                BtDeleteCancel.Content = "Excluir";
            } 
            else
            {               
                BtEditSave.Content = "Salvar";
                BtDeleteCancel.Content = "Cancelar";
            }

        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            _container.GoBack();
        }

        private void BtEditSave_Click(object sender, RoutedEventArgs e)
        {
            if (LockedState)
            {
                LockedState = false;
            } 
            else
            {
                LockedState = true;
            }

            ButtonsStateChange();
        }

        private void BtDeleteCancel_Click(object sender, RoutedEventArgs e)
        {
            if (LockedState)
            {
                LockedState = false;
            }
            else
            {
                LockedState = true;
            }

            ButtonsStateChange();
        }
    }
}
