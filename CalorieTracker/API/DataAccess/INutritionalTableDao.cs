using Models;

namespace API.DataAccess
{
    public interface INutritionalTableDao
    {
        Task<int> CreateNutritionalTable(NutritionalTable nutritionalTable);
        Task<bool> DeleteNutritionalTableById(int id);
        Task<NutritionalTable> GetNutritionalTableById(int Id);
        Task<bool> UpdateNutritionalTable(NutritionalTable nutritionalTable);
    }
}