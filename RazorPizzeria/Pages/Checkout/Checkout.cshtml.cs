
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzeria.Pages.Checkout;

[BindProperties (SupportsGet = true)]
public class CheckoutModel : PageModel
{
    public string PizzaName { get; set; }
    public float PizzaPrice { get; set; } = 2;
    public string ImageTitle { get; set; }

    public void OnGet()
    {
        if (string.IsNullOrWhiteSpace(PizzaName))
        {
            PizzaName = "Custom";
        }
        if (string.IsNullOrWhiteSpace(ImageTitle))
        {
            ImageTitle = "Create";
        }
    }
}
