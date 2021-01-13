using System.Threading.Tasks;

using Protocol.Chat.V1;
using Protocol.Harmonytypes.V1;

namespace HarmonySDK
{
    public sealed partial class ApiClient
    {
        public async Task<GetUserResponse> GetUser(ulong user_id)
            => await _chatService.GetUserAsync(new GetUserRequest { UserId = user_id }, _defaultAuthMetadata);

        public async Task GetUserMetadata(string app_id)
            => await _chatService.GetUserMetadataAsync(new GetUserMetadataRequest { AppId = app_id }, _defaultAuthMetadata);

        public async Task UpdateProfile(string newUsername = null, string newAvatar = null)
        {
            var req = new ProfileUpdateRequest {
                NewUsername = newUsername,
                NewAvatar = newAvatar,
            };
            if (newUsername != null) req.UpdateUsername = true;
            if (newAvatar != null) req.UpdateAvatar = true;
            await _chatService.ProfileUpdateAsync(req, _defaultAuthMetadata);
        }
    }
}