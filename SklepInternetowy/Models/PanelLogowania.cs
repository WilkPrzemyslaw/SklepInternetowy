using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepInternetowy.Models
{
    public class PanelLogowania
    {
        private string _login = "admin";
        private string _haslo = "1234";
        public string login;
        public string haslo;

        public PanelLogowania()
        {

        }
        public PanelLogowania(string l, string h)
        {
            login = l;
            haslo = h;
        }
        public void podajLoginHaslo()
        {
            Console.Clear();
            Console.WriteLine("Podaj login:");
            login = Console.ReadLine();
            Console.WriteLine("Podaj haslo:");
            haslo = Console.ReadLine();

            sprawdzLoginHaslo();
        }

        public void sprawdzLoginHaslo()
        {
           
            
            if (login == _login && haslo == _haslo)
            {
                Console.WriteLine("witaj");
            }
            else
            {
                Console.WriteLine("blednie podane haslo sprobuj jeszcze raz");
                Console.ReadKey();
                podajLoginHaslo();
            }
        }
    }
}