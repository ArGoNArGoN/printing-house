using employee_manager_desktop.Data;
using employee_manager_desktop.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_manager_desktop.Service
{
    public interface INewOrederDataStore
    {
        List<NewOrder> GetNewOrders();
    }
}
