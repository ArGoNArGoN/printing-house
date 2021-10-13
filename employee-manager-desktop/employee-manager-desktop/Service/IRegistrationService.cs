using employee_manager_desktop.MVVM.Models;
using System;

namespace employee_manager_desktop.Service
{
    public interface IRegistrationService
    {
        AuthorizationUserModel RegistrUser(String logIn, String password);
        void GoOut();
    }
}
