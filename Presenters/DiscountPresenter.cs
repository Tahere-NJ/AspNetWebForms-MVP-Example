using DiscountCalculatorWebApp.Models;
using DiscountCalculatorWebApp.Views;
using System;

namespace DiscountCalculatorWebApp.Presenters
{
    public class DiscountPresenter
    {
        private readonly IDiscountView _view;
        private readonly IDiscountService _discountService;

        public DiscountPresenter(IDiscountView view, IDiscountService discountService)
        {
            _view = view;
            _discountService = discountService;
        }

        public void CalculateDiscount()
        {
            try
            {
                decimal price = _view.Price;
                decimal discountedPrice = _discountService.CalculateDiscount(price);
                _view.Result = $"Discounted Price: {discountedPrice}";
            }
            catch (ArgumentException ex)
            {
                _view.ShowError(ex.Message);
            }
        }
    }
}