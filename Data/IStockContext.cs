using Dapper;

namespace StockAPI_Razor.Data
{
    public interface IStockContext
    {
        Task ExecuteAsync<T>(string sql);
        Task ExecuteAsyncWithParameters(string sql, DynamicParameters parameters);
        Task<IEnumerable<T>> QueryAsync<T>(string sql);
        Task<T> QueryFirstOrDefaultAsync<T>(string sql);
    }
}