using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domaci4
{
    class Knjige
    {
        private string imeknjige;
        private string imepisca;
        private int isbn;
        private int godina;
        private int brojstranica;

        public Knjige() { }

        //Unos imena knjige
        public string imeKnjige 
        {

            get { return imeknjige; }
            set 
            {
                imeknjige = value;
                if(imeknjige == "")
                {
                    //Ukoliko korisnik ostavi prazno polje, izbacice error, da mora da unese ime knjige
                    throw new Exception("Morate uneti ime knjige!");
                }
            }
        }

        //Unos ime pisca
        public string imePisca 
        {

            get { return imepisca; }
            set 
            {
                imepisca = value;
                if(imepisca == "")
                {
                    /*Ukoliko korisnik ne unese ime pisca, tj. ostavi prazno polje,
                    izbacice error da mora da unese*/
                    throw new Exception("Morate uneti ime pisca!");
                }
            }
        
        }

        //Unos ISBN broja
        public int ISBN 
        {

            get { return isbn; }
            set 
            {
                //Ukoliko korisnik broj manji od 1, izbacice error da je pogresno i da mora da unese ISBN broj
                if(value < 1)
                {
                    throw new Exception("Morate uneti ISBN broj!");
                }
                isbn = value;
            }

        
        }

        //Unos godine kada je napisana knjiga
        public int Godina 
        {
            get { return godina; }
            set 
            {
                /*Ukoliko korisnik unese da je knjiga je napisana pre 1900. godine,
                izbacice eror da je knjiga previse stara*/
                if(value < 1900)
                {
                    throw new Exception("Knjiga je previse stara!");
                }
                godina = value;
            }

        }

        //Unos broja stranica
        public int brojStranica 
        {
            get { return brojstranica; }
            set 
            {
                if(value < 60)
                {
                    /*Ukoliko korisnik unese da knjiga ima 60 stranica ili manje
                    izbacice error Da knjiga ima premalo stranica*/
                    throw new Exception("Knjiga ima premalo stranica!");
                }
                brojstranica = value;

            }
        }
    }
}
