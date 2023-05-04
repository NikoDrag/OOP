using System;
using System.Collections.Generic;
using System.Text;

namespace Kontakti
{
    class Kontakt
    {
        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private string glavnibroj;

        public string GlavniBroj
        {
            get { return glavnibroj; }
            set { glavnibroj = value; }
        }

        private List<string> ostalibrojevi = new List<string>();

        public Kontakt(string ime, string prezime, string glavnibroj)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.glavnibroj = glavnibroj;
        }


        public void DodajBroj(string dodatnibroj)
        {
            foreach(string broj in ostalibrojevi)
            {
                if (broj == dodatnibroj)
                    return;
            }
            ostalibrojevi.Add(dodatnibroj);
        }


        public void IzbrisiBroj(string dodatniBroj)
        {
            ostalibrojevi.Remove(dodatniBroj);
        }

        public override string ToString()
        {
            return $"{ime}, {Prezime}, {glavnibroj}, [{ostalibrojevi}]";
        }
    }
}
