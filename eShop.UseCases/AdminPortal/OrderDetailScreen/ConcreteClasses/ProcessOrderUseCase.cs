using eShop.CoreBusiness.Services.Interfaces;
using eShop.UseCases.AdminPortal.OrderDetailScreen.AbstractClasses;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;

namespace eShop.UseCases.AdminPortal.OrderDetailScreen.ConcreteClasses
{
    public class ProcessOrderUseCase : IProcessOrderUseCase
    {
        private readonly IOrderRepository orderRepository;
        private readonly IOrderService orderService;

        public ProcessOrderUseCase(IOrderRepository orderRepository, IOrderService orderService)
        {
            this.orderRepository = orderRepository;
            this.orderService = orderService;
        }

        public bool Execute(int orderId, string adminUserName)
        {
            var order = orderRepository.GetOrder(orderId);
            order.AdminUser = adminUserName;
            order.DateProcessed = DateTime.Now;
            // validate Process order via Order services method
            if (orderService.IsValidateProcessOrder(order))
            {
                orderRepository.UpdateOrder(order);
                return true;
            }
            return false;
        }
    }
}
