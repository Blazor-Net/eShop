using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.UI;
using eShop.UseCases.ShoppingCartScreen.AbstractClasses;
using System.Threading.Tasks;

namespace eShop.UseCases.ShoppingCartScreen.ConcreteClasses
{
    public class ViewShoppingCartUseCase : IViewShoppingCartUseCase
    {
        private readonly IShoppingCart shoppingCart;
        public ViewShoppingCartUseCase(IShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }
        public Task<Order> Excecute()
        {
            return shoppingCart.GetOrderAsync();
        }
    }
}
