using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepInternetowy
{
    class Program
    {       
        static void Main(string[] args)
        {

            menu();

        }

        static public void menu()
        {
            Console.Title = "Menu";

            Models.PanelLogowania pl = new Models.PanelLogowania();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Witaj w sklepie internetowym:");
                Console.WriteLine("1. Przeglad");
                Console.WriteLine("2. Zaloguj");
                Console.WriteLine("3. Wyjdz");

                ConsoleKeyInfo klawisz = Console.ReadKey();
                Console.WriteLine();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear(); break;
                    case ConsoleKey.D2:
                        Console.Clear(); pl.podajLoginHaslo(); Console.ReadKey(); break;
                    case ConsoleKey.D3:
                        Environment.Exit(0); break;
                    default: break;
                }
            }
        }
    }
}
