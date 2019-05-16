
using System;

namespace chen {
    abstract class cstrategy
    {
        public abstract void algorithminterace();
    }



    // 具体的算法实现
    class cconcrete_strategya : cstrategy
    {
        public override void algorithminterace()
        {
            Console.WriteLine("算法A的实现");
        }
    }

    class cconcrete_strategyb : cstrategy
    {
        public override void algorithminterace()
        {
            Console.WriteLine("算法B的实现");
        }
    }
}//namespace chen