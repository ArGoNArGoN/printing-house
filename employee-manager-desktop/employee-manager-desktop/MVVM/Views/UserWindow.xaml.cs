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
using System.Windows.Shapes;

namespace employee_manager_desktop.MVVM.Views
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
        }

        private void Close(object sender, RoutedEventArgs e)
            => Close();

        private void Expand(object sender, RoutedEventArgs e) 
            => WindowState = WindowState == WindowState.Normal
                ? WindowState.Maximized
                : WindowState.Normal;

        private void Minimized(object sender, RoutedEventArgs e)
            => WindowState = WindowState.Minimized;

        private void DragOverEx(object sender, MouseButtonEventArgs e) 
            => DragMove();
    }
}
