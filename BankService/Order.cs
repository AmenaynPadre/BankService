using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Order
    {
        public int OrderId { get; set; }
        //public GetCurrentOrderStatus(int orderId);

    }

    public enum OrderStatus
    {
        Unknown = 0,
        Ok = 200,
        ClientError = 300,
        ServiceError = 500
    }
}
