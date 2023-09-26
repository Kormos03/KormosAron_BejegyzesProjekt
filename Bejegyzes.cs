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
            List<string> lista;

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.Szerzo = szerzo;
            this.Tartalom = tartalom;
            this.Likeok = 0;
            this.Letrejott = DateTime.Now;
            this.Szerkesztve = DateTime.Now;
            this.Lista = new List<string>();
        }

        public string Szerzo { get => szerzo; set => szerzo = value; }
        public string Tartalom { get => tartalom; set => tartalom = value;} 
        public int Likeok { get => likeok; set => likeok = value; }
        public DateTime Letrejott { get => letrejott; set => letrejott = value; }
        public DateTime Szerkesztve { get => szerkesztve; set => szerkesztve = value; }
        internal List<string> Lista { get => lista; set => lista = value; }

        public void like()
        {
            Likeok++;
        }
        public override string ToString()
        {
            string everything = Environment.NewLine; { everything = "Szerkesztve: " + this.Szerkesztve; };
            return this.Szerzo + " - " + this.Likeok + " - " + this.Letrejott +  " - " + everything;
        }
    }
}
