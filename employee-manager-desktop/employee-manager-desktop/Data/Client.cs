using Contract.Model;
using employee_manager_desktop.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_manager_desktop.Data
{
    public class Client
        : IClient
    {
        public String FirsName { get; set; }
        public String LastName { get; set; }
        
        public String Company { get; set; }
    }
}
