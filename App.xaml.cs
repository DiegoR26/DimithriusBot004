using Data;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace Dimithrius004
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    { 
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            using (var db = new AppDBContext())
            {
                db.Database.Migrate();
            }

        }

    }

}
