using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.StateStore;
using eShop.UseCases.PluginInterfaces.UI;
using eShop.UseCases.ShoppingCartScreen.AbstractClasses;
using System.Threading.Tasks;

namespace eShop.UseCases.ShoppingCartScreen.ConcreteClasses
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public DeleteProductUseCase(IShoppingCart shoppingCart, IShoppingCartStateStore shoppingCartStateStore)
        {
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }

        public async Task<Order> Execute(int ProductId)
        {
            var order = await shoppingCart.DeleteProductAsync(ProductId);
            shoppingCartStateStore.UpdateLineItemsCount();
            return order;
        }
    }
}
