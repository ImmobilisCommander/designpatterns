namespace Julien.Pattern.ChainOfResponsibility
{
    public abstract class LeaveHandler
    {
        protected LeaveHandler _nextHandler;

        public void SetNextHandler(LeaveHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleRequest(LeaveRequest request);
    }

}