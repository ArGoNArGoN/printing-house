using System;
using System.Collections.Generic;
using employee_manager_desktop.Architecture;

namespace employee_manager_desktop.MVVM.Models
{
    public class Product
        : BaseViewModel
    {
        public String Title { get; set; }
        public Int32 Count { get; set; }

        public IEnumerable<DetailProductModel> Details { get; set; }
    }
}