using Builder.Builder;
using Builder.Director;
using System;
using System.Collections.Generic;
using Builder.Models;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = new ConsoleKeyInfo();
            while (!(key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3))
            {
                var cocina = new Cocina();
                Pizza pizza = null;
                key = ShowMenu();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        pizza = new Pizza{Tamaño = TamañoEnum.Familiar, Nombre = "CuatroQuesos", Masa = "Cocido", Salsa = "Roquefort", Relleno = new List<string>(new string[] { "mozzarela", "gorgonzola", "parmesano", "ricotta" }) };

                        //cocina.RecepcionarProximaPizza(new CuatroQuesosBuilder(TamañoEnum.Familiar));

                        // o en lugar de utilizar funciones acopladas temporalmente
                        // utilizar una única función
                        //pizza = cocina.CocinarPizza(new CuatroQuesosBuilder(TamañoEnum.Familiar));
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        pizza = new Pizza { Tamaño = TamañoEnum.Mediana, Nombre = "Hawaiana", Masa = "Suave", Salsa = "Dulce", Relleno = new List<string>(new string[] { "piña", "tomate", "jamón" }) };

                        //cocina.RecepcionarProximaPizza(new HawaianaBuilder(TamañoEnum.Mediana));

                        // o en lugar de utilizar funciones acopladas temporalmente
                        // utilizar una única función
                        //pizza = cocina.CocinarPizza(new HawaianaBuilder(TamañoEnum.Mediana));
                        break;
                }

                if (key.Key != ConsoleKey.D3 && key.Key != ConsoleKey.NumPad3 && key.Key != ConsoleKey.Escape)
                {
                    //cocina.CocinarPizzaPasoAPaso();
                    //pizza = cocina.PizzaPreparada;
                    Console.WriteLine();
                    Console.WriteLine(pizza.ToString());
                    Wait();
                }
            }
        }

        private static void Wait()
        {
            Console.WriteLine("Press ESC to continue...");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
            }
        }

        private static ConsoleKeyInfo ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Cuatro Quesos Familiar");
            Console.WriteLine("2. Hawaiana Mediana");
            Console.WriteLine("3. Exit");
            return Console.ReadKey();
        }
    }
}
