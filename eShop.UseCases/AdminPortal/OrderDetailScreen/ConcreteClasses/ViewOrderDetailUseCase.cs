﻿using eShop.CoreBusiness.Models;
using eShop.UseCases.AdminPortal.OrderDetailScreen.AbstractClasses;
using eShop.UseCases.PluginInterfaces.DataStore;

namespace eShop.UseCases.AdminPortal.OrderDetailScreen.ConcreteClasses
{
    public class ViewOrderDetailUseCase : IViewOrderDetailUseCase
    {
        private readonly IOrderRepository orderRepository;
        public ViewOrderDetailUseCase(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }       
        public Order Execute(int orderId)
        {
            return orderRepository.GetOrder(orderId);
        }
    }
}
