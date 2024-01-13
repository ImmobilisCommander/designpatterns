namespace Julien.Pattern.BulkHead
{
    public class DatabaseService
    {
        private static readonly SemaphoreSlim _semaphore = new(10);

        public async Task<string> QueryDatabaseAsync(string query)
        {
            await _semaphore.WaitAsync();

            try
            {
                // exécuter la requête à la base de données
                return await ExecuteQuery(query);
            }
            finally
            {
                _semaphore.Release();
            }
        }

        private async Task<string> ExecuteQuery(string query)
        {
            await Task.Delay(1000);

            return "Hello world!";
        }
    }
}