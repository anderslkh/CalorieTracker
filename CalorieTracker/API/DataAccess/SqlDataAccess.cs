using Dapper;
using System.Data.SqlClient;

namespace DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public string ConnectionStringName { get; set; } = "DefaultConnection";

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<T?> LoadSingleData<T, U>(string sql, U parameters)
        {
            T? result;

            try
            {
                string? connectionString = _config.GetConnectionString(ConnectionStringName);

                using SqlConnection connection = new(connectionString);

                result = await connection.QueryFirstOrDefaultAsync<T>(sql, parameters);
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            List<T> result = new();

            try
            {
                string? connectionString = _config.GetConnectionString(ConnectionStringName);

                using SqlConnection connection = new(connectionString);

                result = (await connection.QueryAsync<T>(sql, parameters)).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public async Task<int> EditData<T>(string sql, T parameters)
        {
            int result = 0;

            try
            {
                string? connectionString = _config.GetConnectionString(ConnectionStringName);

                using SqlConnection connection = new(connectionString);

                result = await connection.ExecuteAsync(sql, parameters);
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public async Task<int> CreateData<T>(string sql, T parameters)
        {
            int result = 0;

            try
            {
                string? connectionString = _config.GetConnectionString(ConnectionStringName);

                using SqlConnection connection = new(connectionString);

                result = await connection.ExecuteScalarAsync<int>(sql, parameters);
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }
    }
}
