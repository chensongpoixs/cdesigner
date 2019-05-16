

namespace chen {


    public class ccash_context
    {
        ccash_super cs = null;

        public ccash_context(string type)
        {
            switch (type)// =====> [反射机制]
            {
                case "正常收费":
                    cs = new ccash_normal();
                    break;
                case "满300返100":
                    cs = new ccash_return();
                    break;
                default:
                    System.Console.WriteLine("[ERROR] not type=" + type);
                    
                    break;
            }
        }
        public double get_result(double momey)
        {
            if (cs == null)
            {
                return 0;
            }
            return cs.accept_cash(momey);
        }
    }
}///namespace chen