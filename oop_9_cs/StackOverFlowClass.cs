namespace oop_9_cs
{
    class StackOverFlowClass
    {
        public event StackOverFlowEvent StackOverFlow;
        public void StackOverFlowOn()
        {
            StackOverFlow?.Invoke();
        }
    }
}
