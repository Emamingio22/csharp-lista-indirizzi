using Lista_indirizzi;
using System.IO;
using System.Xml.Linq;

StreamReader indirizzi = File.OpenText("C:\\Users\\HP\\Desktop\\Emanuele\\esercizi\\Lista-indirizzi\\Lista-indirizzi\\data\\addresses.csv");

List<Indirizzi> listaIndirizzi = new List<Indirizzi>();

indirizzi.ReadLine();
while (!indirizzi.EndOfStream)
{
    string riga = indirizzi.ReadLine(); 

    string[] split = riga.Split(",");

    try
    {
      
        string nome = split[0];
        string cognome = split[1];
        string via = split[2];
        string citta = split[3];
        string provincia = split[4];
        int Zip = int.Parse(split[5]);

        Indirizzi indirizzo = new Indirizzi(nome, cognome, via, citta, provincia, Zip);

        listaIndirizzi.Add(indirizzo);
        Console.WriteLine(indirizzo);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
