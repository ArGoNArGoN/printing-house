using employee_manager_desktop.Architecture;
using employee_manager_desktop.MVVM.Models;
using employee_manager_desktop.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace employee_manager_desktop.MVVM.ViewModels
{
    public class NewOrdersViewModel
		: BaseViewModel
	{
		private INewOrederDataStore orederDataStore;

		private Object currentView;
        private List<NewOrderModel> orders;

        public List<NewOrderModel> Orders
        {
            get { return orders; }
            set
            {
                orders = value ?? new List<NewOrderModel>();
                OnPropertyChanged(nameof(Orders));
            }
        }

        public Object CurrentView
        {
			get => currentView;
            set
            {
				currentView = value;
				OnPropertyChanged(nameof(CurrentView));
            }
        }

		public NewOrdersViewModel()
			: base() 
		{
			orederDataStore = new NewOrederDataStore();
            Orders = orederDataStore.GetNewOrders().Select(x => new NewOrderModel(x)).ToList();
            CurrentView = null;
		}
	}
}
