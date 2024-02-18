using Models;
using System.Data.SqlClient;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace API.DataAccess
{
    public class DaoFactory
    {
        public static IDao<NutritionalTable, int> CreateNutritionalTableDao()
        {
            return new NutritionalTableDao(GetConnection());
        }

        public static IDao<FoodItem, int> CreateFoodItemDao()
        {
            return new FoodItemDao(GetConnection());
        }
        public static string GetConnectionString()
        {
            // Build configuration
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Get connection string
            string connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection string not found in appsettings.json");
            }

            return connectionString;
        }

        private static SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());

        }
    }
}
