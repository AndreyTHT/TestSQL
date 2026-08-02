using System.Data;

namespace SQL.Repositories
{
    internal class ProductRepository
    {
        public async Task<DataTable> GetAllProducts()
        {
            string sql = "SELECT * FROM \"Products\"";
            return await SqlConnect.SelectAsync(sql);
        }
    }
}
