using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.UseCases.SearchProductScreen.AbstractClasses
{
    public interface ISearchProductUseCase
    {
        IEnumerable<Product> Excecute(string filter = null);
    }
}
