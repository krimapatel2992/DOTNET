using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    internal interface IGenClass<T> 
    {
        void getData();
        T getUpdatedValue(T passValue);
    }
}
