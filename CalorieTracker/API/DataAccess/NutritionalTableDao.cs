using DataAccess;
using Models;

namespace API.DataAccess
{
    public class NutritionalTableDao : INutritionalTableDao
    {
        private readonly ISqlDataAccess _db;
        public NutritionalTableDao(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<NutritionalTable> GetNutritionalTableById(int Id)
        {
            string query =
                "SELECT Id, Energy_KJ, Energy_Kcal, Fat, Fat_Saturated, Carbohydrates, Sugars, Dietary_Fibers, Protein, Salt where Id = @Id";

            return await _db.LoadSingleData<NutritionalTable, dynamic>(query, new { Id });
        }

        //public Task<List<NutritionalTable>> GetAllNutritionalTables()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<int> CreateNutritionalTable(NutritionalTable nutritionalTable)
        {
            string query =
                "INSERT INTO Nutritional_Table (Energy_KJ, Energy_Kcal, Fat, Fat_Saturated, Carbohydrates, Sugars, Dietary_Fibers, Protein, Salt) " +
                "VALUES(@EnergyKJ, @EnergyKcal, @Fat, @FatSaturated, @Carbohydrates, @Sugars, @DietaryFibers, @Protein, @Salt) " +
                "SELECT SCOPE_IDENTITY()";

            return await _db.CreateData(query, nutritionalTable);
        }

        public async Task<bool> UpdateNutritionalTable(NutritionalTable nutritionalTable)
        {
            string query =
                "UPDATE Nutritional_Table " +
                "SET Energy_KJ = @EnergyKJ, " +
                "Energy_Kcal = @EnergyKcal, " +
                "Fat = @Fat, " +
                "Fat_Saturated = @FatSaturated, " +
                "Carbohydrates = @Carbohydrates, " +
                "Sugars = @Sugars, " +
                "Dietary_Fibers = @DietaryFibers, " +
                "Protein = @Protein, " +
                "Salt = @Salt " +
                "WHERE Id = @Id";

            int result = await _db.EditData(query, nutritionalTable);

            return result > 0;
        }

        public async Task<bool> DeleteNutritionalTableById(int id)
        {
            string query =
                "DELETE FROM Nutritional_Table " +
                "WHERE Id = @Id";

            int result = await _db.EditData(query, new { id });

            return result > 0;
        }
    }
}
