namespace DiscountCalculatorWebApp.Views
{
    public interface IDiscountView
    {
        decimal Price { get; }
        string Result { set; }
        void ShowError(string message);
    }
}