using Discount.API.Entities;

namespace Discount.API.Repositories.Interfaces
{
    public interface IDiscountRepository
    {
        Task<Coupon> GetDiscountAsync(string productName);
        Task<bool> CreateDiscountAsync(Coupon discount);
        Task<bool> UpdateDiscountAsync(Coupon discount);
        Task<bool> DeleteDiscountAsync(string productName);

    }
}
