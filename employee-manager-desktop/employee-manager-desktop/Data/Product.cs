using Contract.Model;
using System;

namespace employee_manager_desktop.Data
{
    public class Product
		: IProduct
	{
		public String Name { get; set; }
		public String Description { get; set; }
	}
}