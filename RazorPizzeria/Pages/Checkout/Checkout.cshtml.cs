
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Checkout;

[BindProperties (SupportsGet = true)]
public class CheckoutModel : PageModel
{
    public string PizzaName { get; set; }
    public float PizzaPrice { get; set; } = 2;
    public string ImageTitle { get; set; }

    private readonly ApplicationDbContext _context;
    public CheckoutModel(ApplicationDbContext context)
    {
        _context= context;
    }

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
        else
        {
            PizzaName = ImageTitle;
        }

        PizzaOrder pizzaOrder = new PizzaOrder();
        pizzaOrder.PizzaName = PizzaName;
        pizzaOrder.BasePrice = PizzaPrice;

        _context.PizzaOrders.Add(pizzaOrder);
        _context.SaveChanges();

    }
}
