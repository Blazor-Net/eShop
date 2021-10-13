using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.UseCases.PluginInterfaces.DataStore
{
    public interface IOrderRepository
    {
        // Get Order By Id 
        Order GetOrder(int id);
        // Get Order By UniqueId 
        Order GetOrderByUniqueId(string uniqueId);
        // Create new Order
        int CreateOrder(Order order);
        // Marking the order is processed
        void UpdateOrder(Order order);
        // Get All orders 
        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetOutstandingOrders();
        IEnumerable<Order> GetProcessedOrders();
        IEnumerable<OrderLineItem> GetLineItemsByOrderId(int orderId);
    }
}
