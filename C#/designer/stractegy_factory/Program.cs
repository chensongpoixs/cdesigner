/**
 * 简单工厂模式和策略模式结合使用
 **/
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

            ccash_context context = new ccash_context("满300返100");
            
            System.Console.WriteLine("cash == " + context.get_result(666.5));
            
            Console.Read();
        }
    }
}//namespace chen
