namespace ConsoleApp1
{
    public class OrderInputModel
    {
        public int UserId { get; set; }
        public List<Product> products = new List<Product>();

        // validate product

        public void ToCart(Product product)
        {
            products.Add(product);
        }
    }
}