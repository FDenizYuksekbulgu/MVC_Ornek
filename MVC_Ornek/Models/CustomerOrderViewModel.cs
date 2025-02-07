namespace MVC_Ornek.Models
{
    //Müşteri ve sipariş bilgilerini bir arada tutan ViewModel sınıfıdır.
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
    }
}
