using eShop.CoreBusiness.Models;

namespace eShop.UseCases.OrderConfirmationScreen.AbstractClass
{
    public interface IViewOrderConfirmationUseCase
    {
        Order Excecute(string uniqueId);
    }
}