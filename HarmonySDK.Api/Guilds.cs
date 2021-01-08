using System.Threading.Tasks;

using Google.Protobuf.Collections;

using Protocol.Chat.V1;

namespace HarmonySDK
{
    public sealed partial class ApiClient
    {
        public async Task<RepeatedField<GetGuildListResponse.Types.GuildListEntry>> GetGuildList()
        {
            var req = new GetGuildListRequest();
            return (await _chatService.GetGuildListAsync(req, _defaultAuthMetadata)).Guilds;
        }
    }
}