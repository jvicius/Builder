using System.Collections.Generic;
using Builder.Models;

namespace Builder.Builder
{
    // BuilderConcreto
    public class HawaianaBuilder : PizzaBuilder
    {
        public HawaianaBuilder(TamañoEnum tamaño)
        {
            _pizza = new Pizza
            {
                Tamaño = tamaño,
                Nombre = "Hawaiana",
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararMasa()
        {
            _pizza.Masa = "Suave";
        }

        public override void PasoAñadirSalsa()
        {
            _pizza.Salsa = "Dulce";
        }

        public override void PasoPrepararRelleno()
        {
            _pizza.Relleno.Add("piña");
            _pizza.Relleno.Add("tomate");
            _pizza.Relleno.Add("jamón");
        }
    }
}
