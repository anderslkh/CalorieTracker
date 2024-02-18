using Models;
using System.Data.SqlClient;

namespace API.DataAccess
{
    public class FoodItemDao : IDao<FoodItem, int>
    {
        private readonly SqlConnection _db;
        public FoodItemDao(SqlConnection db)
        {
            _db = db;
        }

        public Task<int> CreateItem(FoodItem item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<FoodItem>> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Task<FoodItem> GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItem(FoodItem item, int id)
        {
            throw new NotImplementedException();
        }
    }
}
