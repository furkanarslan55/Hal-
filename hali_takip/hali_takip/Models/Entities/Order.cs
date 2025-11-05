namespace hali_takip.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }  // Sipariş ID’si (primary key)

      
        public int CustomerId { get; set; }          

        public DateTime OrderDate { get; set; }      
        public DateTime? ShippedDate { get; set; }   

      
        public decimal TotalAmount { get; set; }     
        public string PaymentMethod { get; set; }    
   
        public string ShippingAddress { get; set; }  
        public string? TrackingNumber { get; set; }  
        public string OrderStatus { get; set; }      


        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
