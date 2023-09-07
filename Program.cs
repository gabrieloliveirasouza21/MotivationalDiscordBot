using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.SlashCommands;
using MotivationalDiscordBot.config;
using MotivationalDiscordBot.TomMorelloCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotivationalDiscordBot {
    internal class Program {

        private static DiscordClient client { get; set; }
        private static CommandsNextExtension commands { get; set; }

        static async Task Main(string[] args) {

            var jsonReader = new JSONReader();
            await jsonReader.LerJSON();

            var discordConfig = new DiscordConfiguration() {
                Intents = DiscordIntents.All,
                Token = jsonReader.token,
                TokenType = TokenType.Bot,
                AutoReconnect = true
            };

            client = new DiscordClient(discordConfig);
            client.Ready += Client_Ready;

            var commandsConfig = new CommandsNextConfiguration() {
                StringPrefixes = new string[] { jsonReader.prefix },
                EnableMentionPrefix = true,
                EnableDms = true,
                EnableDefaultHelp = false
            };

            commands = client.UseCommandsNext(commandsConfig);
            var slashCommandsConfig = client.UseSlashCommands();
            
            slashCommandsConfig.RegisterCommands<TomMorello>();



            await client.ConnectAsync();
            await Task.Delay(-1);


        }

        private static Task Client_Ready(DiscordClient sender, DSharpPlus.EventArgs.ReadyEventArgs args) {
            return Task.CompletedTask;
        }
    }
}
