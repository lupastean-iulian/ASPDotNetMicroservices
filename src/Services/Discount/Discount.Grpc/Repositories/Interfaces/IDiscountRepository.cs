using Discount.Grpc.Entities;

namespace Discount.Grpc.Repositories.Interfaces
{
    public interface IDiscountRepository
    {
        Task<Coupon> GetDiscountAsync(string productName);
        Task<bool> CreateDiscountAsync(Coupon discount);
        Task<bool> UpdateDiscountAsync(Coupon discount);
        Task<bool> DeleteDiscountAsync(string productName);

    }
}
