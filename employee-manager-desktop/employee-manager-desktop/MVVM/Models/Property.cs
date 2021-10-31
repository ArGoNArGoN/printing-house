using System;
using employee_manager_desktop.Architecture;

namespace employee_manager_desktop.MVVM.Models
{
    public class Property
        : BaseModel
    {
        public String Title { get; set; }
        public String Value { get; set; }
    }
}