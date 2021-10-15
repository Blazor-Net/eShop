using eShop.CoreBusiness.Models;

namespace eShop.UseCases.AdminPortal.OrderDetailScreen.AbstractClasses
{
    public interface IViewOrderDetailUseCase
    {
        Order Execute(int orderId);
    }
}