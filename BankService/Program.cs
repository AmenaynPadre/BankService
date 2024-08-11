using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Product1", 100);
            Product product2 = new Product(2, "Product2", 200);
            Product product3 = new Product(3, "Product3", 300);
            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);


            IUser user1 = new User(1, "Name1", 1000, 3);
            IUser user2 = new User(2, "Name2", 2000, 5);
            List<User> users = new List<User>();

            OrderInputModel model = new OrderInputModel();
            model.ToCart(product2);
            model.ToCart(product3);

            model.UserId = 10;

            IBankService bankService = new BankService();
            var x = bankService.PayOrder(model);

            Console.WriteLine(x);



        }
    }
}
