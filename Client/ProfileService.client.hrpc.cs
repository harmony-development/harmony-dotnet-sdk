using System.Text.RegularExpressions;
using Hrpc;
using Protocol = Harmony;

namespace Harmony.Client;

public class ProfileServiceClient
{
    public readonly Dictionary<string, string> DefaultRequestHeaders = new();
    private string _host { get; init; }
    private string _wsHost => new Regex("http").Replace(_host, "ws", 1);
    public readonly HttpClient _client = new();

    public ProfileServiceClient(string host)
    {
        _host = host;
    }
    // unary GetProfile
    public async Task<Protocol.Profile.V1.GetProfileResponse> GetProfile(Protocol.Profile.V1.GetProfileRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Profile.V1.GetProfileRequest, Protocol.Profile.V1.GetProfileResponse>(_host + "/protocol.profile.v1.ProfileService/GetProfile", pm);

    // unary UpdateProfile
    public async Task<Protocol.Profile.V1.UpdateProfileResponse> UpdateProfile(Protocol.Profile.V1.UpdateProfileRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Profile.V1.UpdateProfileRequest, Protocol.Profile.V1.UpdateProfileResponse>(_host + "/protocol.profile.v1.ProfileService/UpdateProfile", pm);

    // unary GetAppData
    public async Task<Protocol.Profile.V1.GetAppDataResponse> GetAppData(Protocol.Profile.V1.GetAppDataRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Profile.V1.GetAppDataRequest, Protocol.Profile.V1.GetAppDataResponse>(_host + "/protocol.profile.v1.ProfileService/GetAppData", pm);

    // unary SetAppData
    public async Task<Protocol.Profile.V1.SetAppDataResponse> SetAppData(Protocol.Profile.V1.SetAppDataRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Profile.V1.SetAppDataRequest, Protocol.Profile.V1.SetAppDataResponse>(_host + "/protocol.profile.v1.ProfileService/SetAppData", pm);

}
