using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SQL.Repositories
{
    internal class OrderRepository
    {
        private readonly SqlExecutor db;

        public OrderRepository(SqlExecutor db)
        {
            this.db = db;
        }

        public async Task<DataTable> GetAllOrders()
        {
            string sql = "SELECT * FROM \"Orders\"";
            return await db.SelectAsync(sql);
        }
    }
}
