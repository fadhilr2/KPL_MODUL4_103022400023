public class KodePaket
{

    string[] NamaPaket =
    {
        "Basic",
        "Standard",
        "Premium",
        "Unlimited",
        "Gaming",
        "Streaming"
    };

    public string getKodePaket(string namaPaket)
    {
        string[] tabelKodePaket =
        {
            "P201",
            "P202",
            "P203",
            "P204",
            "P205",
            "P206"
        };

        int maxNamaPaketLevel = NamaPaket.Length - 1;

        for (int i = 0; i < maxNamaPaketLevel; i++)
        {
            if(NamaPaket[i] == namaPaket) { 
                return tabelKodePaket[i];
            }
        }

        return "Nama Paket tidak sesuai";
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePaket kodePaket = new KodePaket();
        Console.WriteLine(kodePaket.getKodePaket("Basic"));
    }
}
