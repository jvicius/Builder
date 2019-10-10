using Builder.Builder;
using Builder.Director;
using Builder.Models;
using System;

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
                        pizza = cocina.CocinarPizza(new CuatroQuesosBuilder(TamañoEnum.Familiar));
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        pizza = cocina.CocinarPizza(new HawaianaBuilder(TamañoEnum.Mediana));
                        break;
                }

                if (key.Key != ConsoleKey.D3 && key.Key != ConsoleKey.NumPad3 && key.Key != ConsoleKey.Escape)
                {
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
