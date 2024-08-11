using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IBankService
    {
        public OrderResultModel PayOrder(OrderInputModel orderModel);
        public bool GetCreditLimitForUser();
        // public GetCredit()
    }

    public class BankService : IBankService
    {
        public OrderResultModel PayOrder(OrderInputModel orderModel)
        {
            // validate if user exist

            if (!UserExist(orderModel.UserId))
            {
                return new OrderResultModel(OrderStatus.ClientError, 0);
            }


            return new OrderResultModel(OrderStatus.Ok, 1);
        }

        private bool UserExist(int id)
        {
            // ToDo validate user from IUserService , by id

            return true;
        }

        public bool GetCreditLimitForUser()
        {
            return true;
        }
    }
}
