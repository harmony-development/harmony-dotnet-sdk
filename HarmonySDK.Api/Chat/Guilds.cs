using System.Threading.Tasks;

using Google.Protobuf.Collections;

using Protocol.Chat.V1;

namespace HarmonySDK
{
    public sealed partial class ApiClient
    {
        public async Task<ulong> CreateGuild(string name, string picture_url = null)
        {
            var req = new CreateGuildRequest { GuildName = name, PictureUrl = picture_url };
            var res = await _chatService.CreateGuildAsync(req, _defaultAuthMetadata);
            return res.GuildId;
        }

        public async Task ModifyGuild(ulong guild_id, string newName = null, string newPicture = null)
        {
            var req = new UpdateGuildInformationRequest { 
                GuildId = guild_id,
                NewGuildName = newName,
                NewGuildPicture = newPicture,
            };
            if (newName != null) req.UpdateGuildName = true;
            if (newPicture != null) req.UpdateGuildPicture = true;

            await _chatService.UpdateGuildInformationAsync(req, _defaultAuthMetadata);
        }

        public async Task DeleteGuild(ulong guild_id)
            => await _chatService.DeleteGuildAsync(new DeleteGuildRequest { GuildId = guild_id }, _defaultAuthMetadata);

        public async Task<string> CreateInvite(ulong guild_id, string name, int uses = -1)
        {
            var req = new CreateInviteRequest {
                GuildId = guild_id,
                Name = name,
                PossibleUses = uses,
            };
            var res = await _chatService.CreateInviteAsync(req, _defaultAuthMetadata);
            return res.Name;
        }

        public async Task<RepeatedField<GetGuildInvitesResponse.Types.Invite>> GetGuildInvites(ulong guild_id)
            => (await _chatService.GetGuildInvitesAsync(new GetGuildInvitesRequest { GuildId = guild_id }, _defaultAuthMetadata)).Invites;

        public async Task DeleteInvite(ulong guild_id, string name)
        {
            var req = new DeleteInviteRequest {
                GuildId = guild_id,
                InviteId = name,
            };
            await _chatService.DeleteInviteAsync(req, _defaultAuthMetadata);
        }

        public async Task<PreviewGuildResponse> PreviewGuild(string invite)
        {
            var req = new PreviewGuildRequest { InviteId = invite };
            return await _chatService.PreviewGuildAsync(req, _defaultAuthMetadata);
        }

        // Note: Not implementing join/leave guild and guild list methods, until postbox handles guild list stuff

        public async Task<RepeatedField<GetGuildListResponse.Types.GuildListEntry>> GetGuildList()
            => (await _chatService.GetGuildListAsync(new GetGuildListRequest(), _defaultAuthMetadata)).Guilds;
    }
}