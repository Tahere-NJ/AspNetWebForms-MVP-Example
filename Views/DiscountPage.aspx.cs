using DiscountCalculatorWebApp.Models;
using DiscountCalculatorWebApp.Presenters;
using System;

namespace DiscountCalculatorWebApp.Views
{
    public partial class DiscountPage : System.Web.UI.Page, IDiscountView
    {
        private DiscountPresenter _presenter;

        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter = new DiscountPresenter(this, new DiscountService());
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            _presenter.CalculateDiscount();
        }

        // IDiscountView implementation
        public decimal Price
        {
            get
            {
                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                    throw new ArgumentException("Invalid price.");
                return price;
            }
        }

        public string Result
        {
            set => lblResult.Text = value;
        }

        public void ShowError(string message)
        {
            lblError.Text = message;
        }
    }
}