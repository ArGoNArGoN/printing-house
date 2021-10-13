using Contract.Model;
using employee_manager_desktop.MVVM.Models;
using System;

namespace employee_manager_desktop.Data
{
    public class ProductInOrder<T>
        : IProductInOrder<T>
        where T : IProduct
    {
        public T Product { get; set; }
        public Int32 Count { get; set; }
    }
}
