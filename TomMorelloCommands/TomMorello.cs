using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotivationalDiscordBot.TomMorelloCommands {
    internal class TomMorello:ApplicationCommandModule{


        [SlashCommand("Teste", "mano so escreve ai na moral")]
        public async Task Teste1(InteractionContext ctx) {

            await ctx.CreateResponseAsync(InteractionResponseType
                .ChannelMessageWithSource,
                new DiscordInteractionResponseBuilder()
                .WithContent("Rodando esse krl..."));

            var embedMessage = new DiscordEmbedBuilder() {
                Title = "Oloko bixo funcionou, agora vamos para os reclames do plim plim"
            };

            await ctx.Channel.SendMessageAsync(embed : embedMessage);

        }

        //[]

    }
}
