using Basket.API.Entities;

namespace Basket.API.Repositories.Interfaces
{
    public interface IBasketRepository
    {
        Task<ShopingCart?> GetBasketAsync(string userName);
        Task<ShopingCart?> UpdateBasketAsync(ShopingCart basket);
        Task DeleteBasketAsync(string userName);
    }
}
