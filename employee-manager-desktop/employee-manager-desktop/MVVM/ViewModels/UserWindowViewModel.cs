using employee_manager_desktop.Architecture;
using EmployeeManager.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace employee_manager_desktop.MVVM.ViewModels
{
    public sealed class UserWindowViewModel
        : BaseViewModel
    {
        private AuthorizationUserModel userModel;
        private Object currentView;

        private HomeViewModel HomeVM { get; set; }
        private NewOrdersViewModel NewOrdersVM { get; set; }
        private OrdersInProgressViewModel OrdersInProgressVM { get; set; }
        private CompletedOrdersViewModel CompletedOrdersVM { get; set; }

        public ICommand HomeVMCommand { get; private set; }
        public ICommand NewOrdersVMCommand { get; private set; }
        public ICommand OrdersInProgressVMCommand { get; private set; }
        public ICommand CompletedOrdersVMCommand { get; private set; }

        public AuthorizationUserModel UserModel 
        { 
            get => userModel;

            set
            {
                userModel = value;
                OnPropertyChanged(nameof(UserModel));
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

        public UserWindowViewModel()
            : base() 
        {
            InitializeCommand();

            CurrentView = HomeVM;
        }

        private void InitializeCommand()
        {
            HomeVM = new ();
            NewOrdersVM = new ();
            OrdersInProgressVM= new ();
            CompletedOrdersVM = new ();

            HomeVMCommand = new Command(x => { CurrentView = HomeVM; });
            NewOrdersVMCommand = new Command(x => { CurrentView = NewOrdersVM; });
            OrdersInProgressVMCommand = new Command(x => { CurrentView = OrdersInProgressVM; });
            CompletedOrdersVMCommand = new Command(x => { CurrentView = CompletedOrdersVM; });
        }
    }
}
