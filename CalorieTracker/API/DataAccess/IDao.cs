
namespace API.DataAccess
{
    public interface IDao<T, I>
    {
            Task<T> GetItemById(I id);
            Task<List<T>> GetAllItems();
            Task<int> CreateItem(T item);
            Task<bool> UpdateItem(T item, I id);
            Task<bool> DeleteItem(I id);
    }
}
