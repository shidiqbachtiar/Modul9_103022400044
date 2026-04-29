using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using static Modul9_103022400044.transfer;

namespace Modul9_103022400044
{

    public class transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }

    public class confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
    }

    public class BankTransferConfig
    {
        public string lang { get; set; }
        public string methods {  get; set; }

        private const string filePath = "bank_transfer_config.json";

        public BankTransferConfig()
        {
            lang = "en";
            public transfer {
                    threshold = 25000000;
                    low_fee = 6500;
                    high_fee = 15000;
            }
            
            methods = ["RTO (real-time)", "SKN", "“RTGS”", "BI FAST"];
            public confirmation {
                    en = "yes";
                    id = "ya";
            }
        }

        public void UbahBahasa()
        {
            if (lang == "en")
            {
                lang == "id";
            }
        }

        public static BankTransferConfig LoadConfig()
        {
            if (!File.Exists(filePath))
            {
                BankTransferConfig defaultConfig = new BankTransferConfig();
                defaultConfig.SaveConfig();
                return defaultConfig;
            }
        }
    }
}
