using System;

namespace DiscountCalculatorWebApp.Models
{
    public interface IDiscountService
    {
        decimal CalculateDiscount(decimal price);
    }

    public class DiscountService : IDiscountService
    {
        public decimal CalculateDiscount(decimal price)
        {
            if (price < 0)
                throw new ArgumentException("Price cannot be negative.");

            return price * 0.90m; // 10% discount
        }
    }
}