using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace StockAPI_Razor.Data
{
    public class StockContext : IStockContext
    {
        public StockContext() { }
        public IDbConnection CreateConnection()
        {
            var connectionString = $"Data Source=VUHL-H0HJKN3\\SQLEXPRESS;Database=StockCompany;Integrated Security=True; TrustServerCertificate=True;MultipleActiveResultSets=true";
            return new SqlConnection(connectionString);
        }
        public async Task ExecuteAsync<T>(string sql)
        {
            using var connection = CreateConnection();
            await connection.ExecuteAsync(sql);

        }

        public async Task ExecuteAsyncWithParameters(string sql, DynamicParameters parameters)
        {
            await ExecuteAsyncWithParameters(sql, parameters);
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql)
        {
            using var connection = CreateConnection();
            var result = await connection.QueryAsync<T>(sql);
            return result.ToList();
        }

        public async Task<T> QueryFirstOrDefaultAsync<T>(string sql)
        {
            using var connection = CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<T>(sql);
            return result;
        }
    }
}
