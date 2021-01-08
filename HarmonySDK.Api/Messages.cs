using System.Threading.Tasks;

using Protocol.Chat.V1;

namespace HarmonySDK
{
    public sealed partial class ApiClient
    {
        // TODO: support embeds, et al
        public async Task<SendMessageResponse> CreateMessage(ulong guildId, ulong channelId, string content)
        {
            var req = new SendMessageRequest { GuildId = guildId, ChannelId = channelId, Content = content, };
            return await _chatService.SendMessageAsync(req, _defaultAuthMetadata);
        }

        public async Task UpdateMessage(ulong guildId, ulong channelId, string content)
        {
            var req = new UpdateMessageRequest { GuildId = guildId, ChannelId = channelId, Content = content, };
            await _chatService.UpdateMessageAsync(req, _defaultAuthMetadata);
        }

        public async Task DeleteMessage(ulong guildId, ulong channelId, ulong messageId)
        {
            var req = new DeleteMessageRequest { GuildId = guildId, ChannelId = channelId, MessageId = messageId, };
            await _chatService.DeleteMessageAsync(req, _defaultAuthMetadata);
        }
    }
}