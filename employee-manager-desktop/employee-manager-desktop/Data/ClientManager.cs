using Contract.Model;
using employee_manager_desktop.MVVM.Models;
using System;

namespace employee_manager_desktop.Data
{
    public class ClientManager
        : IClientManager
    {
        public String FirsName { get; set; }
        public String LastName { get; set; }
    }
}
