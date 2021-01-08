    using System;
using System.Threading.Tasks;

namespace PingPongBot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var c = new HarmonySDK.Client("url", "token");

            c.Streams.Events.OnMessageSent += (_, ev) => {
                if (ev.Message.Content == "!ping")
                    _ = c.Api.CreateMessage(ev.Message.GuildId, ev.Message.ChannelId, "Pong!");
                return Task.CompletedTask;
            };

            await c.Streams.BeginHomeserverStream();
            Console.WriteLine("Listening to messages!");

            await Task.Delay(-1);
        }
    }
}