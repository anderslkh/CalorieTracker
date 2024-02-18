using Dapper;
using Models;
using System.Data.SqlClient;

namespace API.DataAccess
{
    public class NutritionalTableDao : IDao<NutritionalTable, int>
    {
        private readonly SqlConnection _db;
        public NutritionalTableDao(SqlConnection db)
        {
            _db = db;
        }

        public async Task<NutritionalTable> GetItemById(int id)
        {
            string query =
                "SELECT Id, Energy_KJ, Energy_Kcal, Fat, Fat_Saturated, Carbohydrates, Sugars, Dietary_Fibers, Protein, Salt " +
                "FROM Nutritional_Table " +
                "WHERE Id = @Id";

            return await _db.QuerySingleAsync<NutritionalTable>(query, new { Id = id });
        }

        public async Task<List<NutritionalTable>> GetAllItems()
        {
            List<NutritionalTable> nutritionalTables = null;

            string query =
                "SELECT * " +
                "FROM Nutritional_Table";

            nutritionalTables = (await _db.QueryAsync<NutritionalTable>(query)).ToList();

            return nutritionalTables;
        }

        public async Task<int> CreateItem(NutritionalTable nutritionalTable)
        {
            string query =
                "INSERT INTO Nutritional_Table (Energy_KJ, Energy_Kcal, Fat, Fat_Saturated, Carbohydrates, Sugars, Dietary_Fibers, Protein, Salt) " +
                "OUTPUT INSERTED.Id " +
                "VALUES(@EnergyKJ, @EnergyKcal, @Fat, @FatSaturated, @Carbohydrates, @Sugars, @DietaryFibers, @Protein, @Salt)";

            var result = await _db.ExecuteScalarAsync<int>(query, nutritionalTable);

            return result;
        }

        public async Task<bool> UpdateItem(NutritionalTable nutritionalTable, int id)
        {
            int result = -1;

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

            var param = new
            {
                Id = id,
                nutritionalTable.EnergyKJ,
                nutritionalTable.EnergyKcal,
                nutritionalTable.Fat,
                nutritionalTable.FatSaturated,
                nutritionalTable.Carbohydrates,
                nutritionalTable.Sugars,
                nutritionalTable.DietaryFibers,
                nutritionalTable.Protein,
                nutritionalTable.Salt
            };

            result = await _db.ExecuteAsync(query, param);

            return result > 0;
        }

        public async Task<bool> DeleteItem(int id)
        {
            int result = -1;
            string query =
                "DELETE FROM Nutritional_Table " +
                "WHERE Id = @Id";

            result = await _db.ExecuteAsync(query, new { id });

            return result > 0;
        }
    }
}
