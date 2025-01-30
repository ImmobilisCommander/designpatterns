namespace Julien.Pattern.BulkHead
{
    public interface IDatabaseService
    {
        Task<string> QueryDatabaseAsync(string query);
    }
}