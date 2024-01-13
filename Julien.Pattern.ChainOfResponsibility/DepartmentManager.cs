namespace Julien.Pattern.ChainOfResponsibility
{
    public class DepartmentManager : LeaveHandler
    {
        public override void HandleRequest(LeaveRequest request)
        {
            if (request.Duration < 5)
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