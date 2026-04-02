using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SoundSharp
{
    public class SharpPhoneDataStore
    {
        public List<SmartPhone> Phones { get; set; } = new List<SmartPhone>();
        public List<UserAccount> Users { get; set; } = new List<UserAccount>();
    }

    public class UserAccount
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public int FailedAttempts { get; set; }
        public bool Locked { get; set; }
    }

    public class SharpPhoneFileStorage
    {

        static string current_dir = Environment.CurrentDirectory;
        static string datapath = Directory.GetParent(current_dir).Parent.Parent.FullName;
        static string filepath = Path.Combine(datapath, "data.json");
        private static readonly JsonSerializerOptions Options = new()
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true,
        };
        public SharpPhoneDataStore Data { get; set; } = new SharpPhoneDataStore();
        public string Brand { get; internal set; }
        public string Model { get; internal set; }
        public int Size { get; internal set; }
        public decimal Price { get; internal set; }
        public int Stock { get; internal set; }

        public void Save()
        {
            var json = JsonSerializer.Serialize(Data, Options);
            File.WriteAllText(filepath, json);
        }

        public void Load()
        {
            if (!File.Exists(filepath))
                return;

            string json = File.ReadAllText(filepath);
            Data = System.Text.Json.JsonSerializer.Deserialize<SharpPhoneDataStore>(json, Options) ?? new SharpPhoneDataStore();
        }
    }
}
