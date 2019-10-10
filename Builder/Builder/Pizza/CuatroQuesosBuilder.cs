using System.Collections.Generic;
using Builder.Models;

namespace Builder.Builder
{
    // Otro BuilderConcreto
    public class CuatroQuesosBuilder : PizzaBuilder
    {
        public CuatroQuesosBuilder(TamañoEnum tamaño)
        {
            _pizza = new Pizza
            {
                Tamaño = tamaño,
                Nombre = "CuatroQuesos",
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararMasa()
        {
            _pizza.Masa = "Cocido";
        }

        public override void PasoAñadirSalsa()
        {
            _pizza.Salsa = "Roquefort";
        }

        public override void PasoPrepararRelleno()
        {
            _pizza.Relleno.Add("mozzarela");
            _pizza.Relleno.Add("gorgonzola");
            _pizza.Relleno.Add("parmesano");
            _pizza.Relleno.Add("ricotta");
        }

        public override IComida CrearComida()
        {
            PasoPrepararMasa();
            PasoAñadirSalsa();
            PasoPrepararRelleno();
            return _pizza;
        }
    }
}
