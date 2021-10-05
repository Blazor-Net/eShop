using eShop.CoreBusiness.Models;

namespace eShop.UseCases.ViewProductScreen.AbstractClasses
{
    public interface IViewProductUseCase
    {
        Product Excecute(int id);
    }
}
