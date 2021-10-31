using employee_manager_desktop.Architecture;
using employee_manager_desktop.MVVM.Models;
using System.Collections.Generic;

namespace employee_manager_desktop.MVVM.ViewModels
{
    public class OrderViewModel
        : BaseViewModel
    {
        public OrderModel Order { get; set; }

        public Command CloseCommand { get; set; }

        public OrderViewModel() { }

        public OrderViewModel(OrderModel order, Command closeCommand = null)
        {
            Order = order ?? throw new System.ArgumentNullException(nameof(order));
            CloseCommand = closeCommand;
        }
    }
}
