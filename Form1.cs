using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Domaci4
{
    public partial class Form1 : Form
    {
            //Lista knjiga
            List<Knjige> knjige = new List<Knjige>();
     
        public Form1()
        {
            InitializeComponent();
            //Dodavanje stavki na DataGrid
            DgKnjige.Columns.Add("imeKnjige", "Ime knjige");
            DgKnjige.Columns.Add("imePisca", "Ime pisca");
            DgKnjige.Columns.Add("ISBN", "ISBN");
            DgKnjige.Columns.Add("Godina", "Godina izdavanja");
            DgKnjige.Columns.Add("brojStranica", "Broj stranica");
            //Onemogucavanje da korisnik dodaje i brise redove
            DgKnjige.AllowUserToAddRows = false;
            DgKnjige.AllowUserToDeleteRows = false;
            DgKnjige.ReadOnly = true;
        }

        private void popuniTabelu() 
        {
            DgKnjige.Rows.Clear();
            if(knjige.Count > 0)
            {
                foreach (Knjige knjig in knjige) 
                {

                    DgKnjige.Rows.Add(knjig.imeKnjige, knjig.imePisca, knjig.ISBN, knjig.Godina, knjig.brojStranica);
                
                }
            }
        
        
        }

        /*Ponistavanje unosa da kada se unese jedna knjiga i izbaci na DataGridu
         moze odmah i druga nakon pritiska na button Dodaj*/
        private void ponistiUnos() 
        {
            Imeknjigetxt.Text = "";
            Imepiscatxt.Text = "";
            Isbntxt.Text = "";
            Godinatxt.Text = "";
            Stranicetxt.Text = "";

        }

        //Unos na DataGrid
        private void Dodajbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Knjige knjig = new Knjige();
                knjig.imeKnjige = Imeknjigetxt.Text;
                knjig.imePisca = Imepiscatxt.Text;
                knjig.ISBN = int.Parse(Isbntxt.Text);
                knjig.Godina = int.Parse(Godinatxt.Text);
                knjig.brojStranica = int.Parse(Stranicetxt.Text);
                knjige.Add(knjig);

                popuniTabelu();

                ponistiUnos();
            }

                //Greske
            catch (FormatException)
            {
                MessageBox.Show("Error!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
    }
}
