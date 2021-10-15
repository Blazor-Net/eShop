using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.UseCases.AdminPortal.ProcessedOrdersScreen.AbstractClasses
{
    public interface IViewProcessedOrderUseCase
    {
        IEnumerable<Order> Execute();
    }
}