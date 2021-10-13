using employee_manager_desktop.Architecture;
using employee_manager_desktop.MVVM.Models;
using System;
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
		private LogInViewModel LogInVM { get; set; }

		public ICommand HomeVMCommand { get; private set; }
		public ICommand NewOrdersVMCommand { get; private set; }
		public ICommand OrdersInProgressVMCommand { get; private set; }
		public ICommand CompletedOrdersVMCommand { get; private set; }
		public ICommand LogInVMCommand { get; private set; }

		public AuthorizationUserModel UserModel
		{
			get => userModel;
			set
			{
				userModel = value;
				OnPropertyChanged(nameof(UserModel));
			}
		}

		public String UserLogIn 
		{
			get => UserModel?.LogIn ?? "";
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
			CurrentView = LogInVM;
			LogInVM.RegisrEvent += (ob) =>
            {
                UserModel = ob;
				HomeVMCommand?.Execute(this);
				OnPropertyChanged(nameof(UserLogIn));
			};
		}

        protected override void InitializeCommand()
		{
			HomeVM = new HomeViewModel();
			NewOrdersVM = new NewOrdersViewModel();
			OrdersInProgressVM= new OrdersInProgressViewModel();
			CompletedOrdersVM = new CompletedOrdersViewModel();
			LogInVM = new LogInViewModel();

			HomeVMCommand = new Command(x => { CurrentView = UserModel is null ? (Object)LogInVM : HomeVM; });
			NewOrdersVMCommand = new Command(x => { CurrentView = UserModel is null ? (Object)LogInVM : NewOrdersVM; });
			OrdersInProgressVMCommand = new Command(x => { CurrentView = UserModel is null ? (Object)LogInVM : OrdersInProgressVM; });
			CompletedOrdersVMCommand = new Command(x => { CurrentView = UserModel is null ? (Object)LogInVM : CompletedOrdersVM; });
			LogInVMCommand = new Command(x => { CurrentView = LogInVM; });
		}
	}
}
