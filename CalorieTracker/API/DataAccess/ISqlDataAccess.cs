
namespace DataAccess
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<int> CreateData<T>(string sql, T parameters);
        Task<int> EditData<T>(string sql, T parameters);
        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task<T?> LoadSingleData<T, U>(string sql, U parameters);
    }
}