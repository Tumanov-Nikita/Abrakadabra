using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka
{
    interface Interface1
    {




         int this[int index]
        {
            set;
            get;
        }

        string method1();
        string method2(int b);

    }
}
