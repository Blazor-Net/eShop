namespace eShop.CoreBusiness.Models
{
    public class OrderLineItem
    {
        // ? means can be nullable 
        public int? LineItemId { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        // association with Order 
        public int? OrderId { get; set; }
        // Navigation with product
        public Product Product { get; set; }

    }
}