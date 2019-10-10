using System.Collections.Generic;

namespace Builder.Models
{
    // Producto final
    public class Pizza : IComida
    {
        public string Masa { get; set; }
        public string Salsa { get; set; }
        public List<string> Relleno { get; set; }
        public TamañoEnum Tamaño { get; set; }
        public string Nombre { get; set; }

        public Pizza()
        {

        }

        public Pizza(TamañoEnum tamaño, string masa, string salsa, List<string> relleno) 
            //: this() //contructor manda a llamar al contructor base
        {
            Tamaño = tamaño;
            Masa = masa;
            Salsa = salsa;
            Relleno = relleno;
        }

        public override string ToString()
        {
            return $"Pizza {Nombre} / Tamaño: {Tamaño}, Masa: {Masa}, Salsa: {Salsa}, Relleno: {string.Join("+", Relleno)}";
        }
    }
}
