using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder.Sandwich
{
    public class BasicoBuilder : SandwichBuilder
    {
        public BasicoBuilder(TamañoEnum tamaño)
        {
            _sandwich = new Models.Sandwich(tamaño, new List<string>());
        }

        public override void PasoPrepararRelleno()
        {
            _sandwich.Relleno.Add("Queso Amarillo");
            _sandwich.Relleno.Add("Mayonesa");
            _sandwich.Relleno.Add("Jamon");
        }

        public override IComida CrearComida()
        {
            PasoPrepararRelleno();
            return _sandwich;
        }
    }
}
