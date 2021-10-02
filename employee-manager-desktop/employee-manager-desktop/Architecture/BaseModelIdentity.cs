using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_manager_desktop.Architecture
{
    internal class BaseModelIdentity<T>
        : BaseModel
    {
        protected Int32 identity;

        public BaseModelIdentity() { }
        public BaseModelIdentity(Int32 identity)
        {
            Identity = identity;
        }

        public virtual Int32 Identity
        {
            get => identity;
            set => identity = value;
        }
    }
}
