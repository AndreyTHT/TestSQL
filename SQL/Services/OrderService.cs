using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Net;
using System.Xml.Linq;

namespace SQL.Services
{
    internal class OrderService
    {
        private List<Order> orders = new List<Order>();

        public List<Order> GetOrderListFromTable(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                Order order = new Order
                (
                    Id: (int)row["Id"],
                    UserId: (string?)row["UserId"],
                    TotalPrice: (decimal?)row["TotalPrice"],
                    OrderDate: (DateTime)row["OrderDate"],
                    DeliveryType: (string?)row["DeliveryType"],
                    RecipientName: (string?)row["RecipientName"],
                    RecipientPhone: (string?)row["RecipientPhone"],
                    RecipientEmail: (string?)row["RecipientEmail"],
                    Address: (string?)row["Address"],
                    Comment: (string?)row["Comment"]
                );
                orders.Add(order);
            }
            return orders;
        }
    }
}
