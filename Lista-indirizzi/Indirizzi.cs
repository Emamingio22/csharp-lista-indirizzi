using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_indirizzi
{
    public class Indirizzi
    {

        private string nome;
        private string cognome;
        private string via;
        private string città;
        private string provincia;
        private int zip;

        public Indirizzi(string nome, string cognome, string via, string città, string provincia, int zip)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.via = via;
            this.città = città;
            this.provincia = provincia;
            this.zip = zip;
        }

        public override string ToString()
        {
            string riga = "";
            riga += "Nome: " + this.nome + "\n";
            riga += "Cognome: " + this.cognome + "\n";
            riga += "Via: " + this.via + "\n";
            riga += "Città: " + this.città + "\n";
            riga += "Provincia: " + this.provincia + "\n";
            riga += "ZIP: " + this.zip + "\n";
            riga += "-------------------";
            return riga;
        }
    }
}
