using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KormosAron_BejegyzesProjekt
{
    internal class Bejegyzes
    {
        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime letrejott;
        private DateTime szerkesztve;

        public Bejegyzes(string szerzo, string tartalom, int likeok, DateTime letrejott, DateTime szerkesztve)
        {
            this.Szerzo = szerzo;
            this.Tartalom = tartalom;
            this.Likeok = 0;
            this.Letrejott = DateTime.Now;
            this.Szerkesztve = DateTime.Now;
        }

        public string Szerzo { get => szerzo; set => szerzo = value; }
        public string Tartalom { get => tartalom; set => tartalom = value;} 
        public int Likeok { get => likeok; set => likeok = value; }
        public DateTime Letrejott { get => letrejott; set => letrejott = value; }
        public DateTime Szerkesztve { get => szerkesztve; set => szerkesztve = value; }

        public void like()
        {
            Likeok++;
        }
        public override string ToString()
        {
            string everything = Environment.NewLine; { everything = "Szerkesztve: " + this.Szerkesztve; };
            return this.Szerzo + " - " + this.Likeok + " - " + this.Letrejott + everything;
        }
    }
}
