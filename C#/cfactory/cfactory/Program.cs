using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chen
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationAdd ob =(OperationAdd) cfactory.createOperation("+");
            if (ob != null)
            {
                ob.getObject();
            }
        }
    }
}//namespace chen
