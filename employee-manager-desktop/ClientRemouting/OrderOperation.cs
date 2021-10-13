using Contract.Interface;
using employee_manager_desktop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace ClientRemouting
{
    public class OrderOperation
    {
        private IOrderOperation orderOperation;

        public OrderOperation()
        {
            ChannelServices.RegisterChannel(new TcpClientChannel(), false);
            orderOperation = (IOrderOperation)Activator.GetObject(typeof(IOrderOperation), "tcp://localhost:8081/OrderOperation");
        }

        public List<Order> GetNewOrders()
        {
            return orderOperation.GetNewOrders().Select(x => x).ToList();
        }
    }
}
