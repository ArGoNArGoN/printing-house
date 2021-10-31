using employee_manager_desktop.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_manager_desktop.Service
{
	public interface IOrderStore
	{
		Task<ICollection<OrderModel>> GetAllOrder();
		Task<OrderModel> GetOrder(Int32 id);
	}
}
