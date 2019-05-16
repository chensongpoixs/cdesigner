
using System;

namespace chen {

    //cach abstract 
    abstract class ccash_super
    {
        public abstract double accept_cash(double momey);
    }
    // 正常收费子类
    class ccash_normal : ccash_super
    {
        public override double accept_cash(double momey)
        {
            return momey;
        }
    }

    //打折收费子类
    class ccash_rebate : ccash_super
    {
        private double m_money_robate = 1d;
        public ccash_robate(string money_robate)
        {
            this.m_money_robate = double.Parse(money_robate);

        }
        public override double accept_cash(double momey)
        {
            return momey * m_money_robate;
        }
    }
} // namespace chen