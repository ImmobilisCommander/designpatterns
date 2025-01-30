
namespace Julien.Pattern.BulkHead
{
    public interface IAnyKindOfService
    {
        Task<int> DoWorkWithActionBlockAsync();

        Task<int> DoWorkWithFunctAsync();

        Task<int> DoWorkWithPollyAsync();
    }
}