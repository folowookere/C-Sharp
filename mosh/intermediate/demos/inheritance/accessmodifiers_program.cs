namespace MoshIntDemos

{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            var rating = this.CalculateRating(excludeOrders: true)
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
        }
    }
}