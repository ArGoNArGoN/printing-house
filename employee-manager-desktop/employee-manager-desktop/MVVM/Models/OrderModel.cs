using System;
using System.Linq;
using System.Collections.Generic;
using employee_manager_desktop.Architecture;

namespace employee_manager_desktop.MVVM.Models
{
    public class OrderModel
        : BaseViewModel
    {
        public String PlaceOfDelivery { get; set; }
        public String Description { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime EndDate { get; set; }
        
        public IEnumerable<Product> Products { get; set; }

        public String GetProducts => Products?.Select(x => x.Title)?.Aggregate((x, y) => x + ", " + y);
    }
}
