using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder.Bagget
{
    public class PeperoniBuilder : BaggetBuilder
    {
        public PeperoniBuilder(TamañoEnum tamaño, TipoPanEnum tipoPan)
        {
            _bagget = new Models.Baggett(tamaño, tipoPan, new List<string>());
        }

        public override void PasoPrepararRelleno()
        {
            _bagget.Relleno.Add("Jamon");
            _bagget.Relleno.Add("Peperoni");
            _bagget.Relleno.Add("Salsa Tomate");
        }

        public override IComida CrearComida()
        {
            PasoPrepararRelleno();
            return _bagget;
        }
    }
}
