using BlazingShop.Shared;

namespace BlazingShop.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action Onchange;
        List<Product> Products { get; set; }

        Task LoadProducts(string categoryUrl = null);
        Task<Product> GetProduct(int id);
    }
}
