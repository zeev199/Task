using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.model
{
    public class TypeTask : BaseType
    {
        public TypeDepartment TypeDepartment { get; set; }
    }
    public class TypeAddress : BaseType { }
    public class TypeDepartment : BaseType { }
    public class TypeItem : BaseType { }
    public class TypeWorkStatus : BaseType { }
    public class TypeCar : BaseType { }
    public class TypeConnection : BaseType { }


}
