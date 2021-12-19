using Protocol.Chat.V1;
using Harmony;

namespace Program;

public static class Program
{
    public static async Task Main()
    {
        var token = "h";

        var client = new ChatServiceClient("https://chat.harmonyapp.io:2289");
        client._client.DefaultRequestHeaders.Add("Authorization", token);

        var guilds = await client.GetGuildList(new());
        Console.WriteLine(guilds);

        var guild = await client.GetGuild(new() { GuildId = guilds.Guilds[0].GuildId });
        Console.WriteLine(guild);

        var channels = await client.GetGuildChannels(new() { GuildId = guilds.Guilds[0].GuildId });
        Console.WriteLine(channels);

        await client.SendMessage(new()
        {
            GuildId = guilds.Guilds[0].GuildId,
            ChannelId = channels.Channels[0].ChannelId,
            Content = new()
            {
                TextMessage = new()
                {
                    Content = new()
                    {
                        Text = "this is a test message sent with harmony-dotnet-sdk"
                    }
                }
            },
        });
    }
}