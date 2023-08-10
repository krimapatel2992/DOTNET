using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    interface IMultiGen<T> :IGenClass<T>
    {
        int GetTValue(T TdataValue);

    }
}
