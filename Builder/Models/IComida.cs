using System.Collections.Generic;

namespace Builder.Models
{
    public interface IComida
    {
        string Masa { get; set; }
        string Salsa { get; set; }
        List<string> Relleno { get; set; }
        TamañoEnum Tamaño { get; set; }
        TipoPanEnum TipoPan { get; set; }
        string Nombre { get; set; }
    }
}
