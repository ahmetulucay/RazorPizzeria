
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages;
public class PizzaModel : PageModel
{
    public List<PizzasModel> fakePizzaDb = new List<PizzasModel>()
    { 
        new PizzasModel() {
            ImageTitle="Margerita", 
            PizzaName="Margerita", 
            BasePrice=2, 
            TomatoSauce=true, 
            Cheese=true, 
            FinalPrice=4},
        new PizzasModel() {ImageTitle="Bolognese", PizzaName="Bolognese", BasePrice=2, TomatoSauce=true, Cheese=true, Beef=true, FinalPrice=5},
        new PizzasModel() {ImageTitle="Carbonara", PizzaName="Carbonara", BasePrice=2, TomatoSauce=true, Cheese=true, Ham=true, Mushroom=true, FinalPrice=6},
        new PizzasModel() {ImageTitle="Hawaiian", PizzaName="Hawaiian", BasePrice=2, TomatoSauce=true, Cheese=true, Ham=true, PineApple=true, FinalPrice=10},
        new PizzasModel() {ImageTitle="MeatFeast", PizzaName="MeatFeast", BasePrice=2, TomatoSauce=true, Cheese=true, Ham=true, Beef=true, FinalPrice=6},
        new PizzasModel() {ImageTitle="Mushroom", PizzaName="Mushroom", BasePrice=2, TomatoSauce=true, Cheese=true, Mushroom=true, FinalPrice=5},
        new PizzasModel() {ImageTitle="Pepperoni", PizzaName="Pepperoni", BasePrice=2, TomatoSauce=true, Cheese=true, Pepperoni=true, FinalPrice=5},
        new PizzasModel() {ImageTitle="Seafood", PizzaName="Seafood", BasePrice=2, TomatoSauce=true, Cheese=true, Tuna=true, FinalPrice=5},
        new PizzasModel() {ImageTitle="Vegeterian", PizzaName="Vegeterian", BasePrice=2, TomatoSauce=true, Cheese=true, Mushroom=true, PineApple=true, FinalPrice=10}
    };
    public void OnGet()
    {
    }
}