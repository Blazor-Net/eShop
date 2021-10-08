using eShop.CoreBusiness.Models;
using System.Threading.Tasks;

namespace eShop.UseCases.ShoppingCartScreen.AbstractClasses
{
    public interface IViewShoppingCartUseCase
    {
        Task<Order> Excecute();
    }
}