using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***
 * 
 * 
 * 
 * 策略模式
 **/
namespace chen
{
    class Program
    {
        static void Main(string[] args)
        {
            ccontext context;
            context = new ccontext(new cconcrete_strategya());
            context.ccontext_interace();

            Console.Read();

        }
    }
}//namespace chen
