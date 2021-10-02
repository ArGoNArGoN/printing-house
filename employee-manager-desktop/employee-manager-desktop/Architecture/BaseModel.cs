using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_manager_desktop.Architecture
{
    internal abstract class BaseModel
    {
        public virtual Boolean IsValid { get; } = true;
    }
}
