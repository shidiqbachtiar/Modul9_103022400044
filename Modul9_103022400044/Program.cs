using Modul9_103022400044;

class Program
{
    static void Main(string[] args)
    {
        BankTransferConfig config = BankTransferConfig.LoadConfig();

        Console.WriteLine("Bahasa saat ini: " + config.lang);

        Console.WriteLine("Apakah ingin mengubah bahasa? (y/n)");
        string pilihan = Console.ReadLine();

        if (pilihan.ToLower() == "y")
        {
            config.UbahBahasa();
            Console.WriteLine("Language change to: " + config.lang);
        }

        Console.WriteLine(
    }
}