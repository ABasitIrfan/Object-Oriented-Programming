using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction1
{
    interface IEmployeeNED
    {
        void methodA();
        void methodB();
        void methodC();

    }
    interface IEmployeeUIT:IEmployeeNED,IEmployeeHamdard
    {
        void methodD();
        void methodE();
    //    void methodC();

    }
    interface IEmployeeHamdard
    {
        void methodX();
        void methodY();

    }
}
