namespace chen
{
     internal class Operation
    {
        // public abstract void getObject();
    }


    class OperationAdd : Operation
    {
        public void getObject()
        {
            System.Console.WriteLine("OperationAdd");
        }
    }

    class OperationDel : Operation
    {
        public void getObject()
        {
            System.Console.WriteLine("OperationAdd");
        }
    }

}//namespace chen