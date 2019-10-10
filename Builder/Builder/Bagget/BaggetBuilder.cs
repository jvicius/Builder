using Builder.Creator;
using Builder.Models;

namespace Builder.Builder.Bagget
{
    public abstract class BaggetBuilder : CocinaCreator
    {
        // Protected para que las clases que implementen puedan acceder
        protected Models.Baggett _bagget;

        public string Tamaño { get; set; }

        public IComida ObtenerComida() { return _bagget; }

        // Un paso para cada una de las propiedades
        public virtual void PasoPrepararRelleno()
        {

        }
    }
}
