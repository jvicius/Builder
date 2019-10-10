using System.Collections.Generic;

namespace Builder.Models
{
    public class Baggett : IComida
    {
        public string Masa { get; set; }
        public string Salsa { get; set; }
        public List<string> Relleno { get; set; }
        public TamañoEnum Tamaño { get; set; }
        public TipoPanEnum TipoPan { get; set; }
        public string Nombre { get; set; }

        public Baggett()
        {

        }

        public Baggett(TamañoEnum tamaño, TipoPanEnum tipoPanEnum, List<string> relleno)
        {
            Relleno = relleno;
            Tamaño = tamaño;
            TipoPan = tipoPanEnum;
        }

        public override string ToString()
        {
            return $"Sandwich {Nombre} /Tamaño: {Tamaño}, TipoPan: {TipoPan}, Relleno: {string.Join("+", Relleno)}";
        }
    }
}
