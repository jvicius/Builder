using System.Collections.Generic;
using Builder.Creator;
using Builder.Models;

namespace Builder.Builder
{
    // BuilderConcreto
    public class HawaianaBuilder : CocinaCreator
    {
        public HawaianaBuilder(TamañoEnum tamaño)
        {
            _comida = new Pizza
            {
                Tamaño = tamaño,
                Nombre = "Hawaiana",
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararMasa()
        {
            _comida.Masa = "Suave";
        }

        public override void PasoAñadirSalsa()
        {
            _comida.Salsa = "Dulce";
        }

        public override void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("piña");
            _comida.Relleno.Add("tomate");
            _comida.Relleno.Add("jamón");
        }

        public override IComida CrearComida()
        {
            PasoPrepararMasa();
            PasoAñadirSalsa();
            PasoPrepararRelleno();
            return _comida;
        }
    }
}
