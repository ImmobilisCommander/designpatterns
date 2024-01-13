namespace Julien.Pattern.ChainOfResponsibility
{
    public class HRManager : LeaveHandler
    {
        public override void HandleRequest(LeaveRequest request)
        {
            if (request.Duration < 10)
            {
                // Traiter la demande de congé
            }
            else
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }

}