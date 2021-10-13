using employee_manager_desktop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace employee_manager_desktop.MVVM.Models
{
    public class NewOrderModel
        : NewOrder, INotifyPropertyChanged
    {
        public String GetFullNameClient => $"{Client?.FirsName}, {Client?.LastName} " + Client?.Company;
        public String GetFullNameClientManager => $"{ClientManager?.FirsName}, {ClientManager?.LastName}";
        public String GetAllProduct => ProductInOrders?.Select(x => x.Product?.Name).Aggregate((x, y) => x + $" {y}");

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
