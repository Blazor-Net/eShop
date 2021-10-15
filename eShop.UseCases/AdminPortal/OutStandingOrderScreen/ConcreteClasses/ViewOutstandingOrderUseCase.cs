using eShop.CoreBusiness.Models;
using eShop.UseCases.AdminPortal.OutStandingOrderScreen.AbstractClasses;
using eShop.UseCases.PluginInterfaces.DataStore;
using System.Collections.Generic;

namespace eShop.UseCases.AdminPortal.OutStandingOrderScreen.ConcreteClasses
{
    public class ViewOutstandingOrderUseCase : IViewOutstandingOrderUseCase
    {
        private readonly IOrderRepository orderRepository;

        public ViewOutstandingOrderUseCase(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public IEnumerable<Order> Execute()
        {
            return orderRepository.GetOutstandingOrders();
        }

    }
}
