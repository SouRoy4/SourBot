using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace SourBot.Modules
{
    public class CommandsAsync : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("@everyone");
        }


        [Command("uwu")]
        public async Task hate()
        {
            await ReplyAsync(":weary:");
        }



        [Command("test")]
        public async Task test()
        {
            await ReplyAsync("test");
        }



        [Command("delete76")]
        public async Task DeleteMessage()
        {
            var messages = await Context.Channel.GetMessagesAsync(Context.Message, Direction.After, 2).FlattenAsync();
            var nextMessage = messages.LastOrDefault();

            if (nextMessage != null)
            {
                Console.WriteLine($"Deleting message with content: {nextMessage.Content}");

                _ = Task.Run(async () =>
                {
                    await Task.Delay(TimeSpan.FromSeconds(2));
                    await nextMessage.DeleteAsync();
                    Console.WriteLine("Message deleted.");
                });
            }
            else
            {
                Console.WriteLine("No message to delete.");
            }
        }





    }


}
