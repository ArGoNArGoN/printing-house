using employee_manager_desktop.Architecture;
using employee_manager_desktop.Service;
using EmployeeManager.MVVM.Models;
using System;
using System.Windows.Input;

namespace employee_manager_desktop.MVVM.ViewModels
{
	public class LogInViewModel
		: BaseViewModel
	{
		private IRegistrationService service;

		private AuthorizationUserModel user;
		private String logIn;
		private String passwor;
		private Boolean inProcess;

		public AuthorizationUserModel User
		{
			get { return user; }
			set 
			{
				user = value; 
				OnPropertyChanged(nameof(User)); 
			}
		}
		public String LogIn
		{
			get { return logIn; }
			set { logIn = value ?? ""; OnPropertyChanged(nameof(LogIn)); }
		}
		public String Password
		{
			get { return passwor; }
			set { passwor = value ?? ""; OnPropertyChanged(nameof(Password)); }
		}

		public Boolean IsValid 
			=> LogIn.Length > 5 && Password.Length > 5;
		public Boolean InProcess
        {
			get => inProcess;
			protected set
			{
				inProcess = value;
				OnPropertyChanged(nameof(InProcess));
			}
        }

		public ICommand AuthorizationUserCommand { get; protected set; }

		public LogInViewModel()
			: base()
		{
			LogIn = "";
			Password = "";
			service = new RegistrationService();
		}

        protected override void InitializeCommand()
        {
			AuthorizationUserCommand = new Command(AuthorizationUser, (ob) => 
			{
				OnPropertyChanged(nameof(IsValid));
				return IsValid;
			});
        }

		private void AuthorizationUser(Object ob) 
		{
			InProcess = true;

            try
            {
				User = service.RegistrUser(LogIn, Password);
			}
            catch (Exception)
            {
				User = null;
            }
            finally
            {
				InProcess = false;
            }
		}
	}
}
