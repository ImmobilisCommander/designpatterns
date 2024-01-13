using Julien.Pattern.ChainOfResponsibility;

namespace Julien.Pattern.Tests
{
    public class ChainOfResponsibilityTests
    {
        [Fact]
        public void ChainOfResponsibilityTest()
        {
            LeaveRequest leaveRequest = new()
            {
                Duration = 8
            };

            DepartmentManager departmentManager = new();
            HRManager hrManager = new();
            Director director = new();

            departmentManager.SetNextHandler(hrManager);
            hrManager.SetNextHandler(director);

            departmentManager.HandleRequest(leaveRequest);
        }
    }
}