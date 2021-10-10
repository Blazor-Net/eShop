using eShop.CoreBusiness.Models;
using System.Threading.Tasks;

namespace eShop.UseCases.ShoppingCartScreen.AbstractClasses
{
    public interface IDeleteProductUseCase
    {
        Task<Order> Execute(int ProductId);
    }
}