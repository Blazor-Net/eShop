using eShop.CoreBusiness.Models;
using eShop.UseCases.AdminPortal.ProcessedOrdersScreen.AbstractClasses;
using eShop.UseCases.PluginInterfaces.DataStore;
using System.Collections.Generic;

namespace eShop.UseCases.AdminPortal.ProcessedOrdersScreen.ConcreteClasses
{
    public class ViewProcessedOrderUseCase : IViewProcessedOrderUseCase
    {
        private readonly IOrderRepository orderRepository;

        public ViewProcessedOrderUseCase(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public IEnumerable<Order> Execute()
        {
            return orderRepository.GetProcessedOrders();
        }
    }
}
