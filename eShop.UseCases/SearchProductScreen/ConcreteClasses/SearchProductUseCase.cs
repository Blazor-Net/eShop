using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.SearchProductScreen.AbstractClasses;
using System.Collections.Generic;

namespace eShop.UseCases.SearchProductScreen
{
    public class SearchProductUseCase :ISearchProductUseCase
    {
        private readonly IProductRepository _productRepository;

        public SearchProductUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<Product> Excecute(string filter)
        {
            return _productRepository.GetProducts(filter);
        }       
    }
}
