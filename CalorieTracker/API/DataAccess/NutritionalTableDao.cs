using DataAccess;
using Models;

namespace API.DataAccess
{
    public class NutritionalTableDao
    {
        private readonly ISqlDataAccess _db;
        public NutritionalTableDao(ISqlDataAccess db) { 
            _db = db;
        }

        public Task<NutritionalTable> GetNutritionalTableById(int Id)
        {
            string query = "SELECT Id, Energy_KJ, Energy_Kcal, Fat, Fat_Saturated, Carbohydrates, Sugars, Dietary_Fibers, Protein, Salt where Id = @Id";
            return _db.LoadSingleData<NutritionalTable, dynamic>(query, new { Id });
        }

        public Task<List<NutritionalTable>> GetNutritionalTablesById(int Id)
        {

        }

        public Task<List<NutritionalTable>> GetAllNutritionalTables
    }
}
