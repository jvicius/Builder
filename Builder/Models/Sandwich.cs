using System.Collections.Generic;

namespace Builder.Models
{
    public class Sandwich : IComida
    {
        public string Masa { get; set; }
        public string Salsa { get; set; }
        public List<string> Relleno { get; set; }
        public TamañoEnum Tamaño { get; set; }
        public TipoPanEnum TipoPan { get; set; }
        public string Nombre { get; set; }

        public Sandwich()
        {

        }

        public Sandwich(TamañoEnum tamaño, List<string> relleno)
        {
            Relleno = relleno;
            Tamaño = tamaño;
        }

        public override string ToString()
        {
            return $"Sandwich {Nombre} /Tamaño: {Tamaño}, Relleno: {string.Join("+", Relleno)}";
        }
    }
}
