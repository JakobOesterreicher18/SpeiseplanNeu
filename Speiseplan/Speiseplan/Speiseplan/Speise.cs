using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speiseplan
{
    public class Speise
    {
        private string name, beschreibung, zutaten, bildAdresse;
        private char speiseart;
        private double preis;

        public Speise() { }

        public Speise(string name, string beschreibung, string zutaten, double preis, char speiseart, string bildAdresse)
        {
            this.name = name;
            this.beschreibung = beschreibung;
            this.zutaten = zutaten;
            this.preis = preis;
            this.speiseart = speiseart;
            this.bildAdresse = bildAdresse;
        }

        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }

        public string Beschreibung 
        { 
            get { return beschreibung; } 
            set { beschreibung = value; } 
        }

        public double Preis 
        { 
            get { return preis; } 
            set { preis = value; } 
        }

        public string Zutaten 
        { 
            get { return zutaten; } 
            set { zutaten = value; } 
        }

        public char Speiseart 
        { 
            get { return speiseart; } 
            set { speiseart = value; } 
        }

        public string BildAdresse 
        { 
            get { return bildAdresse; } 
            set { bildAdresse = value; } 
        }
    }
}
