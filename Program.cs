using System.Collections;

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

class MesinKopi
{
    enum State { OFF, STANDBY, BREWING, MAINTENANCE };
    
    public static void Start()
    {
        State state = State.OFF;

        while (true) {
            string command = Console.ReadLine();
            switch (state)
            {
                case State.OFF:
                    if(command == "POWER_ON")
                    {
                        Console.WriteLine("Mesin Off berubah menjadi Standby");
                        state = State.STANDBY;
                    }
                    else
                    {
                        Console.WriteLine("Perubahan state tidak valid");
                    }
                    break;
                case State.STANDBY:
                    if (command == "START_BREW")
                    {
                        Console.WriteLine("Mesin Standby berubah menjadi Brewing");
                        state = State.BREWING;
                    }
                    else if (command == "START_MAINTENANCE")
                    {
                        Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
                        state = State.MAINTENANCE;
                    }
                    else if (command == "POWER_OFF")
                    {
                        Console.WriteLine("Mesin Standby berubah menjadi Off");
                        state = State.OFF;
                    }
                    else
                    {
                        Console.WriteLine("Perubahan state tidak valid");
                    }
                    break;
                case State.BREWING:
                    if (command == "FINISH_BREW")
                    {
                        Console.WriteLine("Mesin Brewing berubah menjadi Standby");
                        state = State.STANDBY;
                    }
                    else
                    {
                        Console.WriteLine("Perubahan state tidak valid");
                    }
                    break;
                case State.MAINTENANCE:
                    if (command == "FINISH_MAINTENANCE")
                    {
                        Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
                        state = State.STANDBY;
                    }
                    else
                    {
                        Console.WriteLine("Perubahan state tidak valid");
                    }
                    break;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePaket kodePaket = new KodePaket();
        Console.WriteLine(kodePaket.getKodePaket("Basic"));
        MesinKopi.Start();
    }
}
