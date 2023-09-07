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


        [SlashCommand("sonhos", "essa é de pular de alegria")]
        public async Task Teste1(InteractionContext ctx) {

            await ctx.CreateResponseAsync(InteractionResponseType
                .ChannelMessageWithSource,
                new DiscordInteractionResponseBuilder()
                .WithContent("Se liga na mensagem pae"));

            var embedMessage = new DiscordEmbedBuilder() {
                Title = "Não desista dos seus sonhos, deixe que eles desistam de você"
            };

            await ctx.Channel.SendMessageAsync(embed : embedMessage);

        }

        //[]

    }
}
