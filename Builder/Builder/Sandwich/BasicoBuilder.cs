using Builder.Creator;
using Builder.Models;
using System.Collections.Generic;

namespace Builder.Builder.Sandwich
{
    public class BasicoBuilder : CocinaCreator
    {
        public BasicoBuilder(TamañoEnum tamaño)
        {
            _comida = new Models.Sandwich(tamaño, new List<string>());
        }

        public override void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("Queso Amarillo");
            _comida.Relleno.Add("Mayonesa");
            _comida.Relleno.Add("Jamon");
        }

        public override IComida CrearComida()
        {
            PasoPrepararRelleno();
            return _comida;
        }
    }
}
