using System.Collections.Generic;
using Builder.Creator;
using Builder.Models;

namespace Builder.Builder
{
    // Otro BuilderConcreto
    public class CuatroQuesosBuilder : CocinaCreator
    {
        public CuatroQuesosBuilder(TamañoEnum tamaño)
        {
            _comida = new Pizza
            {
                Tamaño = tamaño,
                Nombre = "CuatroQuesos",
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararMasa()
        {
            _comida.Masa = "Cocido";
        }

        public override void PasoAñadirSalsa()
        {
            _comida.Salsa = "Roquefort";
        }

        public override void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("mozzarela");
            _comida.Relleno.Add("gorgonzola");
            _comida.Relleno.Add("parmesano");
            _comida.Relleno.Add("ricotta");
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
