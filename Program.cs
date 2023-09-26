using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KormosAron_BejegyzesProjekt
{
    internal class Program
    {
       public static void Main()
        {
            Bejegyzes bejegyzes = new Bejegyzes("asd", "kfsf");
            bejegyzes.like();           //like hozzáadása
            Console.WriteLine(bejegyzes.ToString());
            bejegyzes.adatbazis();
        }
    }
}
