using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speiseplan
{
    class Zutat
    {
        private string einheit, bezeichnung, allergene;
        private int menge;

        public Zutat(string bezeichnung, string allergene, int menge, string einheit)
        {
            this.einheit = einheit;
            this.bezeichnung = bezeichnung;
            this.allergene = allergene;
            this.menge = menge;
        }

        public string Einheit { get => einheit; set => einheit = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public string Allergene { get => allergene; set => allergene = value; }
        public int Menge { get => menge; set => menge = value; }
    }
}
