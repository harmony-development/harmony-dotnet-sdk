using System.Threading.Tasks;

using Protocol.Chat.V1;

namespace HarmonySDK
{
    public sealed partial class ApiClient
    {
        // TODO: support embeds, et al
        public async Task<ulong> CreateMessage(ulong guildId, ulong channelId, string content)
        {
            var req = new SendMessageRequest { GuildId = guildId, ChannelId = channelId, Content = content, };
            return (await _chatService.SendMessageAsync(req, _defaultAuthMetadata)).MessageId;
        }

        public async Task UpdateMessage(ulong guildId, ulong channelId, ulong messageId, string newContent = null)
        {
            var req = new UpdateMessageRequest { GuildId = guildId, ChannelId = channelId, MessageId = messageId, };
            if (newContent != null)
            {
                req.UpdateContent = true;
                req.Content = newContent;
            }
            await _chatService.UpdateMessageAsync(req, _defaultAuthMetadata);
        }

        public async Task DeleteMessage(ulong guildId, ulong channelId, ulong messageId)
        {
            var req = new DeleteMessageRequest { GuildId = guildId, ChannelId = channelId, MessageId = messageId, };
            await _chatService.DeleteMessageAsync(req, _defaultAuthMetadata);
        }

        // todo: don't require before_message
        public async Task<GetChannelMessagesResponse> GetChannelMessages(ulong guild_id, ulong channel_id, ulong before_message)
        {
            var req = new GetChannelMessagesRequest {
                GuildId = guild_id,
                ChannelId = channel_id,
                BeforeMessage = before_message,
            };
            return await _chatService.GetChannelMessagesAsync(req, _defaultAuthMetadata);
        }

        public async Task TriggerAction(ulong guild_id, ulong channel_id, ulong message_id, string action_id, string action_data)
        {
            var req = new TriggerActionRequest {
                GuildId = guild_id,
                ChannelId = channel_id,
                MessageId = message_id,
                ActionId = action_id,
                ActionData = action_data,
            };
            await _chatService.TriggerActionAsync(req, _defaultAuthMetadata);
        }
    }
}