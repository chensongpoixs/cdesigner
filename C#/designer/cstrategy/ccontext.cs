

namespace chen {
    class ccontext
    {
        cstrategy m_strategy;
        public ccontext(cstrategy strategy)
        {
            this.m_strategy = strategy;
        }

        // 接口
        public void ccontext_interace()
        {
            m_strategy.algorithminterace();
        }
    }

}//namespace chen