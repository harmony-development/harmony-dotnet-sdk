using System.Text.RegularExpressions;
using Hrpc;
using Protocol = Harmony;

namespace Harmony.Client;

public class PostboxServiceClient
{
    public readonly Dictionary<string, string> DefaultRequestHeaders = new();
    private string _host { get; init; }
    private string _wsHost => new Regex("http").Replace(_host, "ws", 1);
    public readonly HttpClient _client = new();

    public PostboxServiceClient(string host)
    {
        _host = host;
    }
    // unary Pull
    public async Task<Protocol.Sync.V1.PullResponse> Pull(Protocol.Sync.V1.PullRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Sync.V1.PullRequest, Protocol.Sync.V1.PullResponse>(_host + "/protocol.sync.v1.PostboxService/Pull", pm);

    // unary Push
    public async Task<Protocol.Sync.V1.PushResponse> Push(Protocol.Sync.V1.PushRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Sync.V1.PushRequest, Protocol.Sync.V1.PushResponse>(_host + "/protocol.sync.v1.PostboxService/Push", pm);

    // unary NotifyNewId
    public async Task<Protocol.Sync.V1.NotifyNewIdResponse> NotifyNewId(Protocol.Sync.V1.NotifyNewIdRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Sync.V1.NotifyNewIdRequest, Protocol.Sync.V1.NotifyNewIdResponse>(_host + "/protocol.sync.v1.PostboxService/NotifyNewId", pm);

}
