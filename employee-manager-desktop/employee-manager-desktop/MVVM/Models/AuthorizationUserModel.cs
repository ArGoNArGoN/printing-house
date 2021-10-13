using employee_manager_desktop.Architecture;
using System;

namespace employee_manager_desktop.MVVM.Models
{
    public class AuthorizationUserModel
		: BaseModel
	{
		private String name;
		private String email;
        private String lastName;
        private String middleName;
        private String logIn;

		public AuthorizationUserModel()
			: base() { }

        public String FirstName
		{
			get => name;
			set => name = value?.Trim() ?? "";
		}
		public String Email 
		{ 
			get => email;
			set => email = value ?? "";
		}
        public String MiddleName
		{
            get { return middleName; }
            set { middleName = value ?? ""; }
        }
        public String LastName
        {
            get { return lastName; }
            set { lastName = value ?? ""; }
        }
        public String LogIn 
        {
            get => logIn; 
            set => logIn = value ?? "";
        }

        /// <summary>
        /// метод не работает корректно 
        /// </summary>
        public override bool IsValid => 
            FirstName.Trim().Length > 2
            && LastName.Trim().Length > 2
            && MiddleName.Trim().Length > 2
            && LogIn.Trim().Length > 4
            && Email.Trim().Length > 4;
    }
}
