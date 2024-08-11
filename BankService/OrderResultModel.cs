namespace ConsoleApp1
{
    public class OrderResultModel
    {
        public int Id { get; set; }
        public OrderStatus Status { get; set; }

        public OrderResultModel(OrderStatus statsus, int id)
        {
            Status = statsus;
            Id = id;
        }

        public override string ToString()
        {
            return $"Order Status {Status}, Order Id {Id}";
        }
    }
}