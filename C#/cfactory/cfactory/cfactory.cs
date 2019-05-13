using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 ** 简单工厂模式
 **/
namespace chen {
    class cfactory
    {
        public static Operation createOperation(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationDel();
                    break;
                default:
                    System.Console.WriteLine("[ERROR]operate =  " + operate);
                    break;
            }
            return oper;
        }
    }
}//namespace chen