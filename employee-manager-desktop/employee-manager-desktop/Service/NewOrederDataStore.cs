using ClientRemouting;
using Contract.Interface;
using employee_manager_desktop.Data;
using employee_manager_desktop.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_manager_desktop.Service
{
    public class NewOrederDataStore
        : INewOrederDataStore
    {
        protected OrderOperation orderOperation;

        public NewOrederDataStore()
        {
            orderOperation = new OrderOperation();
        }

        public List<NewOrder> GetNewOrders()
        {
            var list = orderOperation.GetNewOrders();

            return list.Select(x => new NewOrder()
            {
                Client = x.Client,
                ClientManager = x.ClientManager,
                ProductInOrders = x.ProductInOrders,
                DateCreate = x.DateCreate,
                Description = x.Description,
            }).ToList();
        }
    }
}
