using Npgsql;
using System.Data;

namespace SQL.Repositories
{
    internal class ProductRepository
    {
        private readonly SqlExecutor db;

        public ProductRepository (SqlExecutor db)
        {
            this.db = db;
        }

        public async Task<DataTable> GetAllProducts()
        {
            string sql = "SELECT * FROM \"Products\"";
            return await db.SelectAsync(sql);
        }
        public async Task<DataTable> GetProductById(int id)
        {
            var parameter = new NpgsqlParameter("$1", id);
            string sql = "SELECT * FROM \"Products\" WHERE Id = ($1)";
            return await db.SelectAsync(sql, parameter);
        }

    }
}
