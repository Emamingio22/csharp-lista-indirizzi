using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_indirizzi
{
    internal class Indirizzi
    {

        private string nome;
        private string cognome;
        private string via;
        private string città;
        private string provincia;
        private int cap;

        public Indirizzo(string nome, string cognome, string via, string città, string provincia, int cap)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.via = via;
            this.città = città;
            this.provincia = provincia;
            this.cap = cap;
        }

        public override string ToString()
        {
            string riga = "------\nIndirizzo di" + nome + " " + cognome;
            riga += "\n" + via + ", " + città + ", " + provincia + ", " + cap;
            return riga;
        }
    }
}
