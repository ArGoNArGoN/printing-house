using employee_manager_desktop.MVVM.ViewModels;
using employee_manager_desktop.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace employee_manager_desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App 
        : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var view = new UserWindow() { DataContext = new UserWindowViewModel() };

            view.Show();
        }
    }
}
