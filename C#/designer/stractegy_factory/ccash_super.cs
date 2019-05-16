using System;

namespace chen
{
    // base
    abstract class ccash_super
    {
         public abstract double accept_cash(double momey);
    }

   class ccash_normal : ccash_super
    {
        public override double accept_cash(double momey)
        {
            return momey;
        }
    }


    class ccash_return : ccash_super
    {
        public override double accept_cash(double momey)
        {
            return (momey * 0.8);
        }
    }
}