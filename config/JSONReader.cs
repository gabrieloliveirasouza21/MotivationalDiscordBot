using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotivationalDiscordBot.config {
    internal class JSONReader {
        public string token { get; set; }
        public string prefix { get; set; } 

        public async Task LerJSON() {
            using (StreamReader sr = new StreamReader("config.json")) {
                string json = await sr.ReadToEndAsync();
                JSONEstrutura dados = JsonConvert.DeserializeObject<JSONEstrutura>(json);

                this.token = dados.token; 
                this.prefix = dados.prefix;
            }
        }

        public sealed class JSONEstrutura {
        
            public string token { get; set; }

            public string prefix { get; set; }
        
        }
    }
}
