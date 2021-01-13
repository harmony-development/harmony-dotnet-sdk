using System.Threading.Tasks;

using Protocol.Chat.V1;
using Google.Protobuf.Collections;

namespace HarmonySDK
{
    public sealed partial class ApiClient
    {
        public async Task<ulong> CreateChannel(ulong guild_id, string name, bool is_category, ChannelPosition position)
        {
            var req = new CreateChannelRequest {
                GuildId = guild_id,
                ChannelName = name,
                IsCategory = is_category,
                PreviousId = position.previous,
                NextId = position.next,
            };
            var res = await _chatService.CreateChannelAsync(req, _defaultAuthMetadata);
            return res.ChannelId;
        }

        public async Task UpdateChannelName(ulong guild_id, ulong channel_id, string new_name)
        {
            var req = new UpdateChannelInformationRequest { 
                GuildId = guild_id,
                ChannelId = channel_id,
                Name = new_name,
                UpdateName = true,
            };
            await _chatService.UpdateChannelInformationAsync(req, _defaultAuthMetadata);
            return;
        }

        public async Task UpdateChannelPosition(ulong guild_id, ulong channel_id, ChannelPosition position)
        {
            var req = new UpdateChannelOrderRequest {
                GuildId = guild_id,
                ChannelId = channel_id,
                PreviousId = position.previous,
                NextId = position.next,
            };
            await _chatService.UpdateChannelOrderAsync(req, _defaultAuthMetadata);
        }
        
        public async Task DeleteChannel(ulong guild_id, ulong channel_id)
        {
            var req = new DeleteChannelRequest {
                GuildId = guild_id,
                ChannelId = channel_id,
            };
            await _chatService.DeleteChannelAsync(req, _defaultAuthMetadata);
        }

        // TODO: change this to a reasonable return type lol
        public async Task<RepeatedField<GetGuildChannelsResponse.Types.Channel>> GetGuildChannels(ulong guild_id)
        {
            var req = new GetGuildChannelsRequest { GuildId = guild_id };
            var res = await _chatService.GetGuildChannelsAsync(req, _defaultAuthMetadata);
            return res.Channels;
        }

        public async Task SendChannelTyping(ulong guild_id, ulong channel_id)
        {
            var req = new TypingRequest { GuildId = guild_id, ChannelId = channel_id };
            await _chatService.TypingAsync(req, _defaultAuthMetadata);
        }
    }

    public class ChannelPosition
    {
        public ulong previous { get; set; }
        public ulong next { get; set; }

        public ChannelPosition(ulong previous, ulong next)
        {
            this.previous = previous;
            this.next = next;
        }
    }
}