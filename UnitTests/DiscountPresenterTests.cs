using DiscountCalculatorWebApp.Models;
using DiscountCalculatorWebApp.Presenters;
using DiscountCalculatorWebApp.Views;
using System;

namespace DiscountCalculatorWebApp.UnitTests
{
    public class DiscountPresenterTests
    {
        [Fact]
        public void CalculateDiscount_ValidPrice_ReturnsDiscountedPrice()
        {
            // Arrange
            var mockView = new Mock<IDiscountView>();
            mockView.Setup(v => v.Price).Returns(100);

            var mockService = new Mock<IDiscountService>();
            mockService.Setup(s => s.CalculateDiscount(100)).Returns(90);

            var presenter = new DiscountPresenter(mockView.Object, mockService.Object);

            // Act
            presenter.CalculateDiscount();

            // Assert
            mockView.VerifySet(v => v.Result = "Discounted Price: 90");
        }

        [Fact]
        public void CalculateDiscount_NegativePrice_ShowsError()
        {
            // Arrange
            var mockView = new Mock<IDiscountView>();
            mockView.Setup(v => v.Price).Returns(-50);

            var mockService = new Mock<IDiscountService>();
            mockService.Setup(s => s.CalculateDiscount(-50))
                      .Throws(new ArgumentException("Price cannot be negative."));

            var presenter = new DiscountPresenter(mockView.Object, mockService.Object);

            // Act
            presenter.CalculateDiscount();

            // Assert
            mockView.Verify(v => v.ShowError("Price cannot be negative."));
        }
    }
}