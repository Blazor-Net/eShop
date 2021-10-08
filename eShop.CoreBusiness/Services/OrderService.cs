using eShop.CoreBusiness.Models;
using eShop.CoreBusiness.Services.Interfaces;

namespace eShop.CoreBusiness.Services
{
    public class OrderService : IOrderService
    {
        public bool IsValidCustomerInformation(string name, string address, string city, string province, string country)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(province) || string.IsNullOrWhiteSpace(country))
            {
                return false;
            }
            return true;
        }

        public bool IsValidateCreateOrder(Order order)
        {
            // order has to exist
            if (order == null) return false;

            // Order has to have order line items
            if (order.LineItems == null || order.LineItems.Count <= 0) return false;

            // Validation Line Items 
            foreach (var item in order.LineItems)
            {
                if (item.ProductId <= 0 || item.Quantity <= 0 || item.Price <= 0) return false;
            }

            // Validate Customer Info
            if (!IsValidCustomerInformation(order.CustomerName,
                order.CustomerAddress,
                order.CustomerCity,
                order.CustomerStateProvince,
                order.CustomerCountry)) return false;

            return true;
        }

        public bool IsvalidateUpdateOrder(Order order)
        {
            // order has to exist
            if (order == null) return false;
            if (!order.OrderId.HasValue) return false;

            // Order has to have order line items
            if (order.LineItems == null || order.LineItems.Count <= 0) return false;

            // Place Date has to be populated 
            if (!order.DatePlaced.HasValue) return false;

            // 
            if (order.DateProcessed.HasValue || order.DateProcessing.HasValue) return false;

            // Validate UniqueId 
            if (string.IsNullOrWhiteSpace(order.UniqueId)) return false;

            // Validate Customer Info
            if (!IsValidCustomerInformation(order.CustomerName,
                order.CustomerAddress,
                order.CustomerCity,
                order.CustomerStateProvince,
                order.CustomerCountry)) return false;

            return true;
        }

        public bool IsValidateProcessOrder(Order order)
        {
            if (!order.DateProcessed.HasValue || string.IsNullOrWhiteSpace(order.AdminUser)) return false;

            return true;
        }
    }
}
