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

        public async Task UpdateProfile(string newUsername = null, string newAvatar = null, bool? isBot = null)
        {
            var req = new ProfileUpdateRequest();
            if (newUsername != null)
            {
                req.NewUsername = newUsername;
                req.UpdateUsername = true;
            }
            if (newAvatar != null)
            {
                req.NewAvatar = newAvatar;
                req.UpdateAvatar = true;
            }
            if (isBot.HasValue)
            {
                req.IsBot = isBot.Value;
                req.UpdateIsBot = true;
            }
            await _chatService.ProfileUpdateAsync(req, _defaultAuthMetadata);
        }

        public async Task UpdateStatus(UserStatus status)
        {
            var req = new ProfileUpdateRequest();
            req.UpdateStatus = true;

            // this sucks
            switch(status) {
                case UserStatus.OnlineUnspecified:
                    req.NewStatus = Protocol.Harmonytypes.V1.UserStatus.OnlineUnspecified;
                    break;
                case UserStatus.Streaming:
                    req.NewStatus = Protocol.Harmonytypes.V1.UserStatus.Streaming;
                    break;
                case UserStatus.Idle:
                    req.NewStatus = Protocol.Harmonytypes.V1.UserStatus.Idle;
                    break;
                case UserStatus.DoNotDisturb:
                    req.NewStatus = Protocol.Harmonytypes.V1.UserStatus.DoNotDisturb;
                    break;
                case UserStatus.Offline:
                    req.NewStatus = Protocol.Harmonytypes.V1.UserStatus.Offline;
                    break;
            }
            await _chatService.ProfileUpdateAsync(req, _defaultAuthMetadata);
        }
    }

    public enum UserStatus
    {
        OnlineUnspecified,
        Streaming,
        Idle,
        DoNotDisturb,
        Offline
    }
}