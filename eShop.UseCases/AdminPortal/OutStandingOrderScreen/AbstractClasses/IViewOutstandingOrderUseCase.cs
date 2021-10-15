using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.UseCases.AdminPortal.OutStandingOrderScreen.AbstractClasses
{
    public interface IViewOutstandingOrderUseCase
    {
        IEnumerable<Order> Execute();
    }
}