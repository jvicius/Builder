using Builder.Models;

namespace Builder.Creator
{
    public abstract class CocinaCreator
    {
        protected IComida _comida;

        public string Tamaño { get; set; }
        
        public virtual void PasoPrepararMasa()
        {

        }

        public virtual void PasoAñadirSalsa()
        {

        }

        public virtual void PasoPrepararRelleno()
        {

        }

        public virtual void PasoDoblarPizza()
        {

        }

        public abstract IComida CrearComida();
    }
}