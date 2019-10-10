using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Creator;
using Builder.Models;

namespace Builder.Builder.Sandwich
{
    public abstract class SandwichBuilder : CocinaCreator
    {
        // Protected para que las clases que implementen puedan acceder
        protected Models.Sandwich _sandwich;

        public string Tamaño { get; set; }

        public IComida ObtenerComida() { return _sandwich; }

        // Un paso para cada una de las propiedades
        public virtual void PasoPrepararRelleno()
        {

        }
    }
}
