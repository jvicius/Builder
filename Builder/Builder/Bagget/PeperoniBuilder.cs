using Builder.Creator;
using Builder.Models;
using System.Collections.Generic;

namespace Builder.Builder.Bagget
{
    public class PeperoniBuilder : CocinaCreator
    {
        public PeperoniBuilder(TamañoEnum tamaño, TipoPanEnum tipoPan)
        {
            _comida = new Models.Baggett(tamaño, tipoPan, new List<string>());
        }

        public override void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("Jamon");
            _comida.Relleno.Add("Peperoni");
            _comida.Relleno.Add("Salsa Tomate");
        }

        public override IComida CrearComida()
        {
            PasoPrepararRelleno();
            return _comida;
        }
    }
}
