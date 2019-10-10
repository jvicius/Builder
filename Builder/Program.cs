using Builder.Builder;
using Builder.Builder.Bagget;
using Builder.Builder.Sandwich;
using Builder.Creator;
using Builder.Models;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = new ConsoleKeyInfo();
            while (!(key.Key == ConsoleKey.D5 || key.Key == ConsoleKey.NumPad5))
            {
                CocinaCreator cocinaCreator;
                IComida comida = null;
                key = ShowMenu();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        cocinaCreator = new CuatroQuesosBuilder(TamañoEnum.Familiar);
                        comida = cocinaCreator.CrearComida();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        cocinaCreator = new HawaianaBuilder(TamañoEnum.Mediana);
                        comida = cocinaCreator.CrearComida();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        cocinaCreator = new BasicoBuilder(TamañoEnum.Chica);
                        comida = cocinaCreator.CrearComida();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        cocinaCreator = new PeperoniBuilder(TamañoEnum.Chica, TipoPanEnum.Tostado);
                        comida = cocinaCreator.CrearComida();
                        break;
                }

                if (key.Key != ConsoleKey.D5 && key.Key != ConsoleKey.NumPad5 && key.Key != ConsoleKey.Escape)
                {
                    Console.WriteLine();
                    Console.WriteLine(comida.ToString());
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
            Console.WriteLine("3. Sandwich Basico");
            Console.WriteLine("4. Bagget Peperoni Tostado");
            Console.WriteLine("5. Exit");
            return Console.ReadKey();
        }
    }
}
