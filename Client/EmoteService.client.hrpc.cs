using System.Text.RegularExpressions;
using Hrpc;
using Protocol = Harmony;

namespace Harmony.Client;

public class EmoteServiceClient
{
    public readonly Dictionary<string, string> DefaultRequestHeaders = new();
    private string _host { get; init; }
    private string _wsHost => new Regex("http").Replace(_host, "ws", 1);
    public readonly HttpClient _client = new();

    public EmoteServiceClient(string host)
    {
        _host = host;
    }
    // unary CreateEmotePack
    public async Task<Protocol.Emote.V1.CreateEmotePackResponse> CreateEmotePack(Protocol.Emote.V1.CreateEmotePackRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Emote.V1.CreateEmotePackRequest, Protocol.Emote.V1.CreateEmotePackResponse>(_host + "/protocol.emote.v1.EmoteService/CreateEmotePack", pm);

    // unary GetEmotePacks
    public async Task<Protocol.Emote.V1.GetEmotePacksResponse> GetEmotePacks(Protocol.Emote.V1.GetEmotePacksRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Emote.V1.GetEmotePacksRequest, Protocol.Emote.V1.GetEmotePacksResponse>(_host + "/protocol.emote.v1.EmoteService/GetEmotePacks", pm);

    // unary GetEmotePackEmotes
    public async Task<Protocol.Emote.V1.GetEmotePackEmotesResponse> GetEmotePackEmotes(Protocol.Emote.V1.GetEmotePackEmotesRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Emote.V1.GetEmotePackEmotesRequest, Protocol.Emote.V1.GetEmotePackEmotesResponse>(_host + "/protocol.emote.v1.EmoteService/GetEmotePackEmotes", pm);

    // unary AddEmoteToPack
    public async Task<Protocol.Emote.V1.AddEmoteToPackResponse> AddEmoteToPack(Protocol.Emote.V1.AddEmoteToPackRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Emote.V1.AddEmoteToPackRequest, Protocol.Emote.V1.AddEmoteToPackResponse>(_host + "/protocol.emote.v1.EmoteService/AddEmoteToPack", pm);

    // unary DeleteEmotePack
    public async Task<Protocol.Emote.V1.DeleteEmotePackResponse> DeleteEmotePack(Protocol.Emote.V1.DeleteEmotePackRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Emote.V1.DeleteEmotePackRequest, Protocol.Emote.V1.DeleteEmotePackResponse>(_host + "/protocol.emote.v1.EmoteService/DeleteEmotePack", pm);

    // unary DeleteEmoteFromPack
    public async Task<Protocol.Emote.V1.DeleteEmoteFromPackResponse> DeleteEmoteFromPack(Protocol.Emote.V1.DeleteEmoteFromPackRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Emote.V1.DeleteEmoteFromPackRequest, Protocol.Emote.V1.DeleteEmoteFromPackResponse>(_host + "/protocol.emote.v1.EmoteService/DeleteEmoteFromPack", pm);

    // unary DequipEmotePack
    public async Task<Protocol.Emote.V1.DequipEmotePackResponse> DequipEmotePack(Protocol.Emote.V1.DequipEmotePackRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Emote.V1.DequipEmotePackRequest, Protocol.Emote.V1.DequipEmotePackResponse>(_host + "/protocol.emote.v1.EmoteService/DequipEmotePack", pm);

    // unary EquipEmotePack
    public async Task<Protocol.Emote.V1.EquipEmotePackResponse> EquipEmotePack(Protocol.Emote.V1.EquipEmotePackRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Emote.V1.EquipEmotePackRequest, Protocol.Emote.V1.EquipEmotePackResponse>(_host + "/protocol.emote.v1.EmoteService/EquipEmotePack", pm);

}
