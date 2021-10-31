using employee_manager_desktop.Architecture;
using System;
using System.Collections.Generic;

namespace employee_manager_desktop.MVVM.Models
{
    public class DetailProductModel
        : BaseModelIdentity<Int32>
    {
        public Int32 IdentityProduct { get; set; }

        public String DetailProduct { get; set; }
    
        public IEnumerable<Property> Properties { get; set; }
    }
}
