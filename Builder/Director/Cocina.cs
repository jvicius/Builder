using Builder.Builder;
using Builder.Models;

namespace Builder.Director
{
    // Director
    public class Cocina
    {
        private PizzaBuilder _pizzaBuilder;

        public void RecepcionarProximaPizza(PizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public void CocinarPizzaPasoAPaso()
        {
            _pizzaBuilder.PasoPrepararMasa();
            _pizzaBuilder.PasoAñadirSalsa();
            _pizzaBuilder.PasoPrepararRelleno();
        }

        public Pizza PizzaPreparada => _pizzaBuilder.ObtenerPizza();
        
        public Pizza CocinarPizza(PizzaBuilder pizzaBuilder)
        {
            pizzaBuilder.PasoPrepararMasa();
            pizzaBuilder.PasoAñadirSalsa();
            pizzaBuilder.PasoPrepararRelleno();
            return pizzaBuilder.ObtenerPizza();
        }
    }
}