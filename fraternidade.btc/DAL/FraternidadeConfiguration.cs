using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace fraternidade.btc.DAL
{
    public class fraternidadeDBConfiguration : DbConfiguration
    {
        public fraternidadeDBConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}