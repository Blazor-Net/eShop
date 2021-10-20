using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.PluginInterfaces.UI;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.ShoppingCart.LocalStorage
{
    public class ShoppingCart : IShoppingCart
    {
        private const string cstrShoppingCart = "eShop.ShoppingCart";
        private readonly IJSRuntime _jsRuntime;
        private readonly IProductRepository _productRepository;
        public ShoppingCart(IJSRuntime jsRuntime, IProductRepository productRepository)
        {
            _jsRuntime = jsRuntime;
            _productRepository = productRepository;
        }

        public async Task<Order> AddProductAsync(Product product)
        {
            Order order = null;
            try
            {
                 order = await GetOrder();
                order.AddProduct(product.ProductId, 1, product.Price);
                await SetOrder(order);
                return order;
            }
            catch (Exception ex)
            {
                return order;
            }
           
        }
        public async Task<Order> DeleteProductAsync(int productId)
        {
            var order = await GetOrder();
            order.RemoveItem(productId);
            await SetOrder(order);
            return order;
        }

        public Task EmptyShoppingCartAsync()
        {
            return SetOrder(null);
        }

        public async Task<Order> GetOrderAsync()
        {
            return await GetOrder();
        }

        public Task<Order> PlaceOrderAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Order> UpdateOrderAsync(Order order)
        {
            await SetOrder(order);
            return order;
        }

        public async Task<Order> UpdateQuantityAsync(int productId, int quantity)
        {
            var order = await GetOrder();
            if (quantity < 0)
                return order;
            else if (quantity == 0)
                return await DeleteProductAsync(productId);
            var lineItem = order.LineItems.SingleOrDefault(x => x.ProductId == productId);
            if (lineItem != null) lineItem.Quantity = quantity;
            await SetOrder(order);
            return order;
        }
        private async Task<Order> GetOrder() 
        {
            Order order = null;
            var strOrder = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", cstrShoppingCart);
            if (!string.IsNullOrWhiteSpace(strOrder) && strOrder.ToLower() != "null")
            {
                order = JsonConvert.DeserializeObject<Order>(strOrder);
            }
            else 
            {
                order = new Order();
                await SetOrder(order);
            }
            foreach (var item in order.LineItems)
            {
                item.Product = _productRepository.GetProduct(item.ProductId);
            }
            return order;        
        }

        private async Task SetOrder(Order order)
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", cstrShoppingCart,JsonConvert.SerializeObject(order));
        }
    }
}
