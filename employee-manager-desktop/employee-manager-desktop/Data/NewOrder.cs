using Contract.Model;
using employee_manager_desktop.Architecture;
using employee_manager_desktop.Data;
using employee_manager_desktop.MVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace employee_manager_desktop.Data
{
    public class NewOrder
        : BaseModelIdentity<Int32>
    {
        public IClient Client { get; set; }
        public IClientManager ClientManager { get; set; }
        public ICollection<IProductInOrder<IProduct>> ProductInOrders { get; set; }

        public DateTime DateCreate { get; set; }
        public String Description { get; set; }
    }
}
