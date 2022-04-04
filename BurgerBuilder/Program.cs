
using BurgerBuilder;

List<Ingredient> ingredients = new ()
{
    new Ingredient() {Name = "Salad", Number = 2, Price = 2},
    new Ingredient() {Name = "Cutlet", Number = 2, Price = 100},
    new Ingredient() {Name = "Sauce", Number = 1, Price = 5},
    new Ingredient() {Name = "Cucumber", Number = 5, Price = 3},
    new Ingredient() {Name = "Onion", Number = 3, Price = 10},
    new Ingredient() {Name = "Bun", Number = 2, Price = 10}
};

var builder = new BurgerBuilder.BurgerBuilder(ingredients, "BigMac");
var director = new BurgerDirector(builder);

director.Build();

Console.WriteLine(builder.GetBurger());