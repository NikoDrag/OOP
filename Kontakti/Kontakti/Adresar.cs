using System;
using System.Collections.Generic;
using System.Text;

namespace Kontakti
{
    class Adresar
    {
        public Dictionary<string, Kontakt> Kontakti = new Dictionary<string, Kontakt>();

        public void Dodaj(Kontakt k)
        {
            Kontakti.Add(k.GlavniBroj, k);
        }
        public void Dodaj(string ime, string prezime, string glavnibroj)
        {
            Kontakti.Add(glavnibroj, new Kontakt(ime, prezime, glavnibroj));
        }
        public void Blokiraj(string broj)
        {
            Kontakti.Remove(broj);
        }

        public void Share(string file, string glavniBroj)
        {
            
        }
        //kreira fajl sa informacijama o kontaktu sa zadatim brojem
        
        public void Receive(string file)
        {

        } 
        //čita informacije iz binarnog fajla koji sadrži informacije o jednom
        //kontaktu i dodaje novi kontakt u kolekciju ukoliko kontakt sa tim glavnim brojem već ne postoji.
        
        public void Backup(string file)
        {

        }
        //čuva sve informacije o kontaktima u zadatom tekstualnom fajlu na
        //sledeći način:


    }
}
